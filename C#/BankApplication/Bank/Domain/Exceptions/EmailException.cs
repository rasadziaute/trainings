using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Exceptions
{
    public class EmailException : Exception
    {
        public EmailException(string message) : base(message)
        {

        }
    }
}
