using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    class Savings: Account
    {
        public Savings() : base()
        {

        }

        public override bool Deposit(double Amount)
        {
            balance = balance + Amount;
            return true;
        }

        public override string WithDraw(double Amount)
        {
            amount = Amount;
            if (amount > balance)
            {
                return "Your account has insufficient balance";
            }
            else
            {
                balance = balance - Amount;
                return $"Successfully withdrawed {amount}";
            }
            
        }
    }
}
