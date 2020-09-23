using Bank.Domain.Entities;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Services.Interfaces
{
    public interface IAccountService
    {
        Account GetById(Guid id);
        List<Account> GetAll();
        void CreateAccount(double balance, AccountType Type, out Guid id);
        void Withdraw(Account account, double amount);
        void Deposit(Account account, double amount);
    }
}
