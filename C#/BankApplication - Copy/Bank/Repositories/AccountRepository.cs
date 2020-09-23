using Bank.Domain.Entities;
using Bank.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly List<Account> _accounts = new List<Account>();

        public void CreateAccount(Account account)
        {
            _accounts.Add(account);
        }

        //public List<Account> GetAll()
        //{
        //    return _accounts;
        //}

        //public Account GetById(Guid id)
        //{
        //    return GetAll().FirstOrDefault(s => s.Id == id);
        //}

        public void Deposit(Account account, double amount)
        {
            account.Balance +=  amount;
        }

        public void Withdraw(Account account, double amount)
        {
            account.Balance -= amount;
        }
    }
}
