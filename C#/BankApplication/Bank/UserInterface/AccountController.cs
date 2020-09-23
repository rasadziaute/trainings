using Bank.Domain.Entities;
using Bank.Domain.Enums;
using Bank.Domain.Exceptions;
using Bank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.UserInterface
{
    public class AccountController
    {
        private readonly IAccountService _accountService;
        private readonly ICustomerService _customerService;

        public AccountController(IAccountService accountService, ICustomerService customerService)
        {
            _accountService = accountService;
            _customerService = customerService;
        }

        Guid customerId;

        public void RunBankManagementSystem()
        {
            Console.WriteLine("Please Register");
            CreateCustomer();

            var operation = "";
            while (operation != "q")
            {
                Console.WriteLine("What do you want to do? \n 1.Create an account \n 2.Show All Your Accounts Information \n 3.Deposit Amount \n 4.Withdraw Amount \n 5.Clear Screen \n 6.Quit (q)");
                operation = Console.ReadLine();

                if (operation == "1")
                {
                    CreateAccount();
                }
                else if (operation == "2")
                {
                    ShowAllAccountsInformation();
                }
                else if (operation == "3")
                {
                    Deposit();
                }
                else if (operation == "4")
                {
                    Withdraw();
                }
                else if (operation == "5")
                {
                    Console.Clear();
                }
            };
            
        }

        private void CreateCustomer()
        {
            Guid id;

            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth \n Year");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("Month");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("Day");
            var day = int.Parse(Console.ReadLine());


            while (!DateOfBirth.DateValidation(day, month, year))
            {
                Console.WriteLine("Date of brth is not correct");
            }

            var dateOfBirth = new DateOfBirth(day, month, year);

            _customerService.CreateCustomer(name, dateOfBirth, out id);
            customerId = id;

            Console.WriteLine($"You registered successfuly. Your identication Id {customerId}");

        }

        private void CreateAccount()
        {
            Console.WriteLine("Account type \n 1.Savings \n 2.Current");
            var type = Console.ReadLine();
            AccountType accountType;
            if (type == "1" || type == "Savings")
            {
                accountType = AccountType.Savings;
            }
            else
            {
                accountType = AccountType.Current;
            }

            Guid id = new Guid();
            bool isCreated = false;
            do
            {
                Console.WriteLine("Enter balance amount");
                var balance = double.Parse(Console.ReadLine());
                try
                {
                    _accountService.CreateAccount(balance, accountType, out id);
                    _customerService.CreateCustomerAccount(customerId, id);
                    isCreated = true;

                }
                catch (WithdrawDepositException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!isCreated);

            Console.WriteLine($"Your account was created with Id {id}");
        }

        private void ShowAllAccountsInformation()
        {
            var accounts = _accountService.GetAll();
            if (accounts.Count > 0)
            {
                foreach (var account in accounts)
                {
                    Console.WriteLine($"Id {account.Id}, type {account.Type}, balance {account.Balance}");
                }
            }
            else
            {
                Console.WriteLine("You don't have any accounts.");
            }
            
        }

        private void Deposit()
        {
            var accountId = new Guid();
            string input = "";
            double amount = 0;
            bool isCompleted = false;
            while(!isCompleted && input != "q")
            {
                try
                {
                    Console.WriteLine("Enter account id");
                    input = Console.ReadLine();
                    accountId = Guid.Parse(input);
                    if (_accountService.GetById(accountId) != null)
                    {
                        Console.WriteLine("Write an amount to deposit");
                        amount = double.Parse(Console.ReadLine());

                        var account = _accountService.GetById(accountId);
                        _accountService.Deposit(account, amount);

                        Console.WriteLine("Deposit was successful");
                        isCompleted = true;
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }
                catch (Exception)
                {
                    if (input != "q")
                    {
                        Console.WriteLine("Invalid account Id or deposit sum");
                    }
                }
            };
        }

        private void Withdraw()
        {
            var accountId = new Guid();
            string input = "";
            double amount = 0;
            bool isCompleted = false;
            while (!isCompleted && input != "q")
            {
                try
                {
                    Console.WriteLine("Enter account id");
                    input = Console.ReadLine();
                    accountId = Guid.Parse(input);
                    if (_accountService.GetById(accountId) != null)
                    {
                        Console.WriteLine("Write an amount to deposit");
                        amount = double.Parse(Console.ReadLine());

                        var account = _accountService.GetById(accountId);
                        _accountService.Withdraw(account, amount);

                        Console.WriteLine("Withdraw was successful");
                        isCompleted = true;
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }
                catch (WithdrawDepositException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception)
                {
                    if (input != "q")
                    {
                        Console.WriteLine("Invalid account Id or deposit sum");
                    }
                }
            };
        }
    }
}
