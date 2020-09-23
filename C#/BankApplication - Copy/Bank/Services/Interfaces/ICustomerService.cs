using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Services.Interfaces
{
    public interface ICustomerService
    {

        Customer CreateCustomer(string firstName, string lastName, string email, string userName, string password, DateOfBirth dateOfBirth);
        Customer GetById(Guid id);
        List<Customer> GetAll();
    }
}
