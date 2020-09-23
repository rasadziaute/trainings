﻿using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
        List<Customer> GetAll();
        Customer GetById(Guid id);
        List<CustomerAccount> GetCustomerAccounts(Guid id);
        void CreateCustomerAccount(CustomerAccount customerAccount);
    }
}
