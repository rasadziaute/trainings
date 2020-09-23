using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        void CreateAccount(Account account);
        void Withdraw(Account account, double amount);
        void Deposit(Account account, double amount);
    }
}
