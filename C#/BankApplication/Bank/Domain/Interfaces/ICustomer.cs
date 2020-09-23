using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Interfaces
{
    public interface ICustomer
    {
        Guid Id { get; set; }
        string Name { get; set; }
        DateOfBirth DateOfBirth { get; set; }
    }
}
