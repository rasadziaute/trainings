using Bank.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Domain.Entities
{
    public class Customer : ICustomer
    {
        private readonly List<Account> _accounts = new List<Account>();
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public DateOfBirth DateOfBirth { get; set; }

        public List<Account> Accounts => _accounts.ToList();

        public Customer(string name, DateOfBirth dateOfBirth, IEnumerable<Account> accounts, out Guid id)
        {
            id = Id;
            Name = name;
            DateOfBirth = dateOfBirth;
            _accounts = accounts.ToList();
        }

    }
}
