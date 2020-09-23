using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        Account GetById(Guid id);
        List<Account> GetAll();

        //Account Get(Guid id);
        //List<Account> Get();
        void CreateAccount(Account account);
        void Withdraw(Account account, double amount);
        void Deposit(Account account, double amount);
    }
}
