using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Savings : Account
    {
        private double _maxWithdrawAmount = 500;
        public Savings(int id, string customerName, double balance):base()
        {
            Id = id;
            CustomerName = customerName;
            Balance = balance;
        }
        public override string Deposit(double amount)
        {
            Balance += amount;
            return "Deposit was successful";
        }

        public override string Withdraw(double amount)
        {
            if (amount < _maxWithdrawAmount && amount < Balance)
            {
                Balance -= amount;
                return "Withdraw was successful";
            }
            else
            {
                return $"Amount exceeded max limit {_maxWithdrawAmount} or amount was bigger than balance {Balance}";
            }
        }
    }
}
