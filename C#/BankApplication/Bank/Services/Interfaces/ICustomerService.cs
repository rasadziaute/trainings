using Bank.Domain.Entities;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Services.Interfaces
{
    public interface ICustomerService
    {
        Account CreateAccount(double balance, AccountType type, Guid customerId);
        Customer CreateCustomer(string firstName, string lastName, string email, string userName, string password, DateTime dateOfBirth);

        void Deposit(Account account, double amount);
        void Withdraw(Account account, double amount);
    }
}
