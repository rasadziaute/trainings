using Bank.Domain.Enums;
using Bank.Domain.Exceptions;
using Bank.Domain.Interfaces;
using Bank.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Bank.Domain.Entities
{
    public class Customer : ICustomer
    {
        [Column("CustomerId")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }


        public List<Account> Accounts { get; set; } = new List<Account>();


        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string email, string userName, string password, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            Password = password;
            DateOfBirth = dateOfBirth;
        }
    }
}
