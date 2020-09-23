using Bank.Domain.Entities;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Interfaces
{
    public interface IAccount
    {
        Guid Id { get; set; }
        double Balance { get; set; }
        AccountType Type { get; set; }
    }
}
