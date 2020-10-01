using Bank.Domain.Entities;
using Bank.Domain.Enums;
using Bank.Domain.Exceptions;
using Bank.Domain.Interfaces;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Bank.UserInterface
{
    public class BankApplicationController
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerRepository _customerRepository;
        private Customer customer;
        private bool _isAuthenticated = false;

        public BankApplicationController(ICustomerService customerService, ICustomerRepository customerRepository)
        {
            _customerService = customerService;
            _customerRepository = customerRepository;
        }

        public void RunBankManagementSystem()
        {
            var operation = "";
            Console.WriteLine("Welcome to crappy bank");
            while (!_isAuthenticated)
            {
                Console.WriteLine(" 1.Register \n 2.Log in");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        CreateCustomer();
                        break;
                    case "2":
                        GetCustomer();
                        break;
                }
            }

            
            while (operation != "q")
            {
                Console.WriteLine("\nWhat do you want to do? \n 1.Create an account \n 2.Show All Your Accounts Information \n 3.Deposit Amount \n 4.Withdraw Amount \n 5.View your personal information \n 6.Clear Screen \n 7.Quit (q)");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        CreateAccount();
                        break;
                    case "2":
                        ShowAllAccountsInformation();
                        break;
                    case "3":
                        Deposit();
                        break;
                    case "4":
                        Withdraw();
                        break;
                    case "5":
                        GetCustomerDetails();
                        break;
                    case "6":
                        Console.Clear();
                        break;
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
            while (!email.Contains("@"))
            {
                Console.WriteLine("Email is not valid. Enter a valid email.");
                email = Console.ReadLine();
            }
            while (_customerRepository.GetCustomerEmail(email))
            {
                Console.WriteLine("This email already exists. Enter a non existing email.");
                email = Console.ReadLine();
            }

            Console.WriteLine("Enter your User Name");
            var userName = Console.ReadLine();
            while (userName != userName.ToLower())
            {
                Console.WriteLine("User name should be in lower cases");
                userName = Console.ReadLine();
            }

            Console.WriteLine("Enter your date of birth \n Year");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("Month");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("Day");
            var day = int.Parse(Console.ReadLine());


            while (!DateOfBirth.DateValidation(day, month, year))
            {
                Console.WriteLine("Date of brth is not correct");
                Console.WriteLine("Year");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine("Month");
                month = int.Parse(Console.ReadLine());
                Console.WriteLine("Day");
                day = int.Parse(Console.ReadLine());
            }

            var date = $"{year}/{month}/{day}";
            DateTime dateOfBirth = Convert.ToDateTime(date);

            string password;
            string password1;

            Console.WriteLine("Create a password");
            password = Console.ReadLine();
            var regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{12,}$");
            while (!regex.Match(password).Success)
            {
                Console.WriteLine("Password is not according to standards. Create a password");
                password = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Repeat your password");
                password1 = Console.ReadLine();

                if (password != password1)
                {
                    Console.WriteLine("Passowrd does not match");
                }
            } while (password != password1);

            customer = _customerService.CreateCustomer(firstName, lastName, email, userName, password, dateOfBirth.Date);
            _isAuthenticated = true;


            Console.WriteLine("You registered successfuly.");

            RegistrationEmail.SendRegistrationEmail(email);

        }

        private void GetCustomer()
        {
            Console.WriteLine("Enter your identification Id");
            var input = Guid.TryParse(Console.ReadLine(), out Guid customerId);
            if (input)
            {
                customer = _customerRepository.Get(customerId);
                if (customer == null)
                {
                    Console.WriteLine("Customer with this Id does not exist");
                }
                else
                {
                    Console.WriteLine("Enter your password");
                    var password = Console.ReadLine();
                    if (password != customer.Password)
                    {
                        Console.WriteLine("Password is not correct");
                    }
                    else
                    {
                        _isAuthenticated = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Identification Id is not in a correct format");
            }
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
                try
                {
                    Console.WriteLine("Enter balance amount");
                    var input = double.TryParse(Console.ReadLine(), out double balance);
                    if (input)
                    {
                        var customerAccount = _customerService.CreateAccount(balance, accountType, customer.Id);
                        Console.WriteLine($"Your account was created successfully with Account Id {customerAccount.Id}");
                        customer.Accounts.Add(customerAccount);
                        isCreated = true;
                    }
                    else
                    {
                        Console.WriteLine("Balance is not in a correct format");
                    }
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
                    Console.WriteLine($"Account Id {account.Id}, Account type {account.Type}, balance {account.Balance}");
                }
            }
            else
            {
                Console.WriteLine("You don't have any accounts.");
            }
            
        }

        private void Deposit()
        {
            string input = "";
            bool isCompleted = false;
            while (!isCompleted && input != "q")
            {
                Console.WriteLine("Enter account id");
                input = Console.ReadLine();
                var isGuid = Guid.TryParse(input, out Guid accountId);

                if (isGuid)
                {
                    var account = customer.Accounts.FirstOrDefault(s => s.Id == accountId);

                    if (account != null)
                    {
                        Console.WriteLine("Write an amount to deposit");
                        var isDouble = double.TryParse(Console.ReadLine(), out double amount);

                        if (isDouble)
                        {
                            _customerService.Deposit(account, amount);

                            Console.WriteLine("Deposit was successful");
                            isCompleted = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Account Id format");
                }

            }
        }

        private void Withdraw()
        {
            string input = "";
            bool isCompleted = false;
            while (!isCompleted && input != "q")
            {
                try
                {
                    Console.WriteLine("Enter account id");
                    input = Console.ReadLine();
                    var isGuid = Guid.TryParse(input, out Guid accountId);
                    if (isGuid)
                    {
                        var account = customer.Accounts.FirstOrDefault(s => s.Id == accountId);

                        if (account != null)
                        {
                            Console.WriteLine("Write an amount to withdraw");
                            var isDouble = double.TryParse(Console.ReadLine(), out double amount);

                            if (isDouble)
                            {
                                _customerService.Withdraw(account, amount);

                                Console.WriteLine("Withdraw was successful");
                                isCompleted = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid withdrawal amount number");
                            } 
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Id format");
                    }
                }
                catch (WithdrawDepositException e)
                {
                    Console.WriteLine(e.Message);
                }
            };
        }

        private void GetCustomerDetails()
        {
            Console.WriteLine($"Identification Id {customer.Id} \n Full name: {customer.FirstName} {customer.LastName} \n User Name {customer.UserName} \n Date of Birth {customer.DateOfBirth} \n Email {customer.Email} \n Number of accounts {customer.Accounts.Count}");
        }
    }
}
