using Bank.Domain.Enums;
using Bank.Domain.Exceptions;
using Bank.Domain.Interfaces;
using Bank.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Domain.Entities
{
    public class Customer : ICustomer
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateOfBirth DateOfBirth { get; set; }


        public List<Account> Accounts { get; private set; }

        private double _minimalBalance = 100000;
        private double _dailyWithdraw = 20000;

        public Customer(string firstName, string lastName, string email, string userName, string password, DateOfBirth dateOfBirth, ICustomerRepository customerRepository, IAccountRepository accountRepository)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            Password = password;
            DateOfBirth = dateOfBirth;
            Accounts = new List<Account>();
            _customerRepository = customerRepository;
            _accountRepository = accountRepository;
        }

        public Account CreateAccount(double balance, AccountType type)
        {
            if (!(type != AccountType.Current || balance > _minimalBalance))
            {
                throw new WithdrawDepositException($"Minimal balance is {_minimalBalance}");
            }
            var account = new Account(balance, type);
            _customerRepository.CreateAccount(account);
            Accounts.Add(account);
            return account;
        }

        public void Deposit(Account account, double amount)
        {
            _accountRepository.Deposit(account, amount);
        }

        public void Withdraw(Account account, double amount)
        {
            if (account.Balance < amount)
            {
                throw new WithdrawDepositException($"You don't have enough in your account to withdraw {amount}");
            }
            if (!(account.Type != AccountType.Current || amount < _dailyWithdraw))
            {
                throw new WithdrawDepositException($"Maximum daily withdraw is {_dailyWithdraw}");
            }
            _accountRepository.Withdraw(account, amount);
        }

    }
}
