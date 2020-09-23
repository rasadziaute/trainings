using Bank.Domain.Entities;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Interfaces
{
    public interface ICustomer
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        DateOfBirth DateOfBirth { get; set; }

        Account CreateAccount(double balance, AccountType type);
        void Deposit(Account account, double amount);
        void Withdraw(Account account, double amount);
    }

}
