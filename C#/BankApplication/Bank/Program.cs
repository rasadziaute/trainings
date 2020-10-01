using Bank.Domain;
using Bank.Domain.Entities;
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
            var appDbContext = new AppDbContext();
            var accountRepository = new AccountRepository(appDbContext);
            var customerAccountRepository = new CustomerAccountRepository(appDbContext);
            var customerRepository = new CustomerRepository(accountRepository, customerAccountRepository, appDbContext);
            var customerService = new CustomerService(customerRepository, accountRepository);

            var accountController = new BankApplicationController(customerService, customerRepository);

            accountController.RunBankManagementSystem();

        }
    }
}
