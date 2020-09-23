using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    abstract class Account
    {
        public string custName;
        public DateofBirth dateOfBirth;
        public double balance;
        protected string accType;
        public double amount;
        public abstract bool Deposit(double Amount);
        public abstract string WithDraw(double Amount);

        public Account(string name, DateofBirth dateofbirth, double balance)
        {
            custName = name;
            dateOfBirth = dateofbirth;
            this.balance = balance;
        }

        protected Account()
        {

        }
        public string GetaccType()
        {
            accType = Console.ReadLine();
            return accType;
        }

        public void DisplayAccountDeatils()
        {

            Console.WriteLine($"Customer Name {custName}");
            Console.WriteLine($"Customer dateOfBirth {dateOfBirth}");
            Console.WriteLine($" Balance {balance}");

        }
    }
}
