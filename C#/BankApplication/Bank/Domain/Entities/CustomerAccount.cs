using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bank.Domain.Entities
{
    public class CustomerAccount
    {
        public Guid CustomerId { get; set; }
        public Guid AccountId { get; set; }

        public CustomerAccount()
        {

        }

        public CustomerAccount(Guid customerId, Guid accountId)
        {
            CustomerId = customerId;
            AccountId = accountId;
        }

    }
}
