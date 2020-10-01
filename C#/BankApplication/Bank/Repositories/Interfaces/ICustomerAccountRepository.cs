using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Repositories.Interfaces
{
    public interface ICustomerAccountRepository
    {
        List<CustomerAccount> Get(Guid customerId);
        void Create(CustomerAccount customerAccount);
    }
}
