using Bank.Domain;
using Bank.Domain.Entities;
using Bank.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bank.Repositories
{
    class CustomerRepository: ICustomerRepository
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ICustomerAccountRepository _customerAccountRepository;
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(IAccountRepository accountRepository, ICustomerAccountRepository customerAccountRepository, AppDbContext appDbContext)
        {
            _accountRepository = accountRepository;
            _customerAccountRepository = customerAccountRepository;
            _appDbContext = appDbContext;
        }

        public void CreateCustomer(Customer customer)
        {
            _appDbContext.Customer.Add(customer);
            _appDbContext.SaveChanges();    
        }

        public void CreateAccount(Account account, Guid id)
        {
            _customerAccountRepository.Create(new CustomerAccount(id, account.Id));
            _accountRepository.CreateAccount(account);
        }

        public bool GetCustomerEmail(string email)
        {
            if (_appDbContext.Customer.FirstOrDefault(s => s.Email == email) != null)
            {
                return true;
            }
            return false;
        }

        public Customer Get(Guid id)
        {
            var customer = _appDbContext.Customer.FirstOrDefault(s => s.Id == id);
            var customerAccounts = _customerAccountRepository.Get(customer.Id);
            foreach (var account in customerAccounts)
            {
                customer.Accounts.Add(_accountRepository.Get(account.AccountId));
            }

            return customer;
        }
    }
}
