using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    class Current: Account
    {
        public double minBalance = 100000;
        private double dailywithdraw = 20000;

        public override bool Deposit(double Amount)
        {
            amount = Amount;
            this.balance = balance + amount;
            return true;
        }

        public override string WithDraw(double Amount)
        {
            if (CheckDailyLimitation(Amount))
            {
                amount = Amount;
                if (amount > balance)
                {
                    return "Your account has insufficient balance";
                }

                else
                {
                    balance = balance - amount;
                    return $"Successfully withdrawed {amount}";

                }
            }
            else
            {
                return $"Daily withdraw limit cannot exceed {dailywithdraw}";
            }
            
        }

        public bool CheckDailyLimitation(double Amount)
        {
            if (Amount < dailywithdraw)
            {
                Console.WriteLine("true on daily");
                return true;
            }
            else
            {
                Console.WriteLine("false on daily");
                return false;
            }
        }
    }
}
