using Bank.Domain.Entities;
using Bank.Domain.Enums;
using Bank.Domain.Exceptions;
using Bank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.UserInterface
{
    public class CustomerController
    {
        private readonly ICustomerService _customerService;
        private Customer customer;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void RunBankManagementSystem()
        {
            Console.WriteLine("Please Register");
            CreateCustomer();

            var operation = "";
            while (operation != "q")
            {
                Console.WriteLine("What do you want to do? \n 1.Create an account \n 2.Show All Your Accounts Information \n 3.Deposit Amount \n 4.Withdraw Amount \n 5.View your personal information \n 6.Clear Screen \n 7.Quit (q)");
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
                    GetCustomerDetails();
                }
                else if (operation == "6")
                {
                    Console.Clear();
                }
            };
            
        }

        private void CreateCustomer()
        {
            Console.WriteLine("Enter your First Name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter your Email");
            var email = Console.ReadLine();

            Console.WriteLine("Enter your User Name");
            var userName = Console.ReadLine();

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

            string password;
            string password1;
            do
            {
                Console.WriteLine("Create a password");
                password = Console.ReadLine();

                Console.WriteLine("Repeat your password");
                password1 = Console.ReadLine();

                if (password != password1)
                {
                    Console.WriteLine("Passowrd does not match");
                }
            } while (password != password1);

            customer = _customerService.CreateCustomer(firstName, lastName, email, userName, password, dateOfBirth);
            
            Console.WriteLine("You registered successfuly.");

            //RegistrationEmail.SendRegistrationEmail(email);

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

            bool isCreated = false;
            do
            {
                Console.WriteLine("Enter balance amount");
                var balance = double.Parse(Console.ReadLine());
                try
                {
                    var customerAccount = customer.CreateAccount(balance, accountType);
                    Console.WriteLine($"Your account was created successfully with Account Id {customerAccount.Id}");
                    isCreated = true;

                }
                catch (WithdrawDepositException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!isCreated);
        }

        private void ShowAllAccountsInformation()
        {
            var accounts = customer.Accounts;
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
                    var account = customer.Accounts.FirstOrDefault(s => s.Id == accountId);

                    if (account != null)
                    {
                        Console.WriteLine("Write an amount to deposit");
                        amount = double.Parse(Console.ReadLine());

                        customer.Deposit(account, amount);

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
                    var account = customer.Accounts.FirstOrDefault(s => s.Id == accountId);

                    if (account != null)
                    {
                        Console.WriteLine("Write an amount to withdraw");
                        amount = double.Parse(Console.ReadLine());

                        customer.Withdraw(account, amount);

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

        private void GetCustomerDetails()
        {
            Console.WriteLine($" Name: {customer.FirstName} \n Date of Birth {customer.DateOfBirth.DisplayDate()} \n Number of accounts {customer.Accounts.Count}");
        }
    }
}
