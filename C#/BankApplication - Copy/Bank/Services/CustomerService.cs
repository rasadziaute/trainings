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

        public CustomerService(ICustomerRepository customerRepository, IAccountRepository accountRepository)
        {
            _customerRepository = customerRepository;
            _accountRepository = accountRepository;
        }

        public Customer CreateCustomer(string firstName, string lastName, string email, string userName, string password, DateOfBirth dateOfBirth)
        {
            var customer = new Customer(firstName, lastName, email, userName, password, dateOfBirth, _customerRepository, _accountRepository);
            _customerRepository.CreateCustomer(customer);
            return customer;
        }

        public Customer GetById(Guid id)
        {
            return _customerRepository.GetById(id);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

    }
}
