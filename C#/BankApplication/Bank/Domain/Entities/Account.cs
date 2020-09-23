using Bank.Domain.Enums;
using Bank.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Domain.Entities
{
    public class Account : IAccount
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public double Balance { get; set; }
        public AccountType Type { get; set; }

        public Account(double balance, AccountType type, out Guid id)
        {
            id = Id;
            Balance = balance;
            Type = type;
        }




    }
}
