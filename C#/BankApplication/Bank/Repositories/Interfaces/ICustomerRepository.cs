using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
        bool GetCustomerEmail(string email);
        Customer Get(Guid id);
        void CreateAccount(Account account, Guid id);
    }
}
