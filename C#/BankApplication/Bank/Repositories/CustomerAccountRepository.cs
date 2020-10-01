using Bank.Domain;
using Bank.Domain.Entities;
using Bank.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Repositories
{
    public class CustomerAccountRepository : ICustomerAccountRepository
    {
        private readonly AppDbContext _appDbContext;
        public CustomerAccountRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(CustomerAccount customerAccount)
        {
            _appDbContext.CustomerAccount.Add(customerAccount);
            _appDbContext.SaveChanges();
        }

        public List<CustomerAccount> Get(Guid customerId)
        {
            return _appDbContext.CustomerAccount.Where(s => s.CustomerId == customerId).ToList();
        }
    }
}
