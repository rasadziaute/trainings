using Bank.Domain.Entities;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Services
{
    class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;
        public Guid id;

        public CustomerService(ICustomerRepository customerRepository, IAccountRepository accountRepository)
        {
            _customerRepository = customerRepository;
            _accountRepository = accountRepository;
        }

        public void CreateCustomer(string name, DateOfBirth dateOfBirth, out Guid id)
        {
            _customerRepository.CreateCustomer(new Customer(name, dateOfBirth, Enumerable.Empty<Account>(), out id));
        }

        public Customer GetById(Guid id)
        {
            return _customerRepository.GetById(id);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerAccounts(Guid id)
        {
            var customer = _customerRepository.GetById(id);
            var customerAccounts = _customerRepository.GetCustomerAccounts(id);
            foreach (var customerAccount in customerAccounts)
            {
                var account = _accountRepository.GetById(customerAccount.AccountId);
                customer.Accounts.Add(account);
            }

            return customer;
        }

        public void CreateCustomerAccount(Guid customerId, Guid accountId)
        {
            _customerRepository.CreateCustomerAccount(new CustomerAccount(customerId, accountId));
        }

    }
}
