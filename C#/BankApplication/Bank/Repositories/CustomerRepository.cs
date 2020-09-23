using Bank.Domain.Entities;
using Bank.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Repositories
{
    class CustomerRepository: ICustomerRepository
    {
        private readonly List<Customer> _customers = new List<Customer>();
        private readonly List<CustomerAccount> _customerAccounts = new List<CustomerAccount>();

        public void CreateCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public Customer GetById(Guid id)
        {
            return GetAll().FirstOrDefault(s => s.Id == id);
        }

        public List<CustomerAccount> GetCustomerAccounts(Guid id)
        {
            return _customerAccounts.FindAll(s => s.CustomerId == id);
        }

        public void CreateCustomerAccount(CustomerAccount customerAccount)
        {
            _customerAccounts.Add(customerAccount);  
        }
    }
}
