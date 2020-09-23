using Bank.Repositories;
using Bank.Services;
using Bank.UserInterface;
using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //var accountController = new CustomerController(new AccountService(new AccountRepository()), new CustomerService(new CustomerRepository(), new AccountRepository()));
            var accountController = new CustomerController(new CustomerService(new CustomerRepository(new AccountRepository()), new AccountRepository()));
            accountController.RunBankManagementSystem();
        }
    }
}
