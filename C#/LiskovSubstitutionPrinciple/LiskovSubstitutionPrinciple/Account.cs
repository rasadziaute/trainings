using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public abstract class Account
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public abstract string Deposit(double amount);
        public abstract string Withdraw(double amount);
    }
}
