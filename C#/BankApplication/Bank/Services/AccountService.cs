using Bank.Domain.Entities;
using Bank.Domain.Enums;
using Bank.Domain.Exceptions;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        private double _minimalBalance = 100000;
        private double _dailyWithdraw = 20000;
        public Guid id;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public void CreateAccount(double balance, AccountType type, out Guid id)
        {

            if (!IsValidBalance(balance, type))
            {
                throw new WithdrawDepositException($"Minimal balance is {_minimalBalance}");
            }
            _accountRepository.CreateAccount(new Account(balance, type, out id));

        }

        public Account GetById(Guid id)
        {
            return _accountRepository.GetById(id);
        }

        public List<Account> GetAll()
        {
            return _accountRepository.GetAll();
        }

        public void Deposit(Account account, double amount)
        {
            _accountRepository.Deposit(account, amount);
        }

        public void Withdraw(Account account, double amount)
        {

            if (!IsValidWithdraw(account, amount))
            {
                throw new WithdrawDepositException($"Maximum daily withdraw is {_dailyWithdraw}");
            }

            _accountRepository.Withdraw(account, amount);
        }


        private bool IsValidWithdraw(Account account, double amount)
        {
            return (account.Type != AccountType.Current || amount < _dailyWithdraw);
        }

        private bool IsValidBalance(double balance, AccountType type)
        {
            return (type != AccountType.Current || balance > _minimalBalance);

        }
    }
}
