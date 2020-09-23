using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Exceptions
{
    public class WithdrawDepositException: Exception
    {
        public WithdrawDepositException(string message):base(message)
        {

        }
    }
}
