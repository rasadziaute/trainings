using Bank.Domain.Entities;
using Bank.Domain.Enums;
using Bank.Domain.Exceptions;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Services
{
    class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;

        private double _minimalBalance = 100000;
        private double _dailyWithdraw = 20000;

        public CustomerService(ICustomerRepository customerRepository, IAccountRepository accountRepository)
        {
            _customerRepository = customerRepository;
            _accountRepository = accountRepository;
        }

        public Customer CreateCustomer(string firstName, string lastName, string email, string userName, string password, DateTime dateOfBirth)
        {
            var customer = new Customer(firstName, lastName, email, userName, password, dateOfBirth);
            _customerRepository.CreateCustomer(customer);
            return customer;
        }

        public Account CreateAccount(double balance, AccountType type, Guid customerId)
        {
            if (!(type != AccountType.Current || balance > _minimalBalance))
            {
                throw new WithdrawDepositException($"Minimal balance is {_minimalBalance}");
            }
            var account = new Account(balance, type);
            _customerRepository.CreateAccount(account, customerId);
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
