using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        Account Get(Guid id);
        void CreateAccount(Account account);
        void Withdraw(Account account, double amount);
        void Deposit(Account account, double amount);
    }
}
