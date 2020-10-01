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
        DateTime DateOfBirth { get; set; }
        List<Account> Accounts { get; set; }
    }

}
