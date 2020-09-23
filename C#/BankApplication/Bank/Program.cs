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
            var accountController = new AccountController(new AccountService(new AccountRepository()), new CustomerService(new CustomerRepository(), new AccountRepository()));
            accountController.RunBankManagementSystem();
        }
    }
}
