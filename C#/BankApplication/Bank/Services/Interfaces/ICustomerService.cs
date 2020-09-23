using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Services.Interfaces
{
    public interface ICustomerService
    {

        void CreateCustomer(string name, DateOfBirth dateOfBirth, out Guid id);
        Customer GetById(Guid id);
        List<Customer> GetAll();
        void CreateCustomerAccount(Guid customerId, Guid accountId);
    }
}
