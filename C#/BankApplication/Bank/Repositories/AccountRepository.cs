using Bank.Domain;
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
        private readonly AppDbContext _appDbContext;
        public AccountRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreateAccount(Account account)
        {
            _appDbContext.Account.Add(account);
            _appDbContext.SaveChanges();
        }

        public Account Get(Guid id)
        {
            return _appDbContext.Account.SingleOrDefault(s => s.Id == id);
        }

        public void Deposit(Account account, double amount)
        {
            var customerAccount = Get(account.Id);
            customerAccount.Balance += amount;
            _appDbContext.SaveChanges();
        }

        public void Withdraw(Account account, double amount)
        {
            var customerAccount = Get(account.Id);
            account.Balance -= amount;
            _appDbContext.SaveChanges();
        }
    }
}
