using Bank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<CustomerAccount> CustomerAccount { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Bank;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerAccount>().HasKey(t => new { t.CustomerId, t.AccountId });

            modelBuilder.Entity<Customer>().Ignore("Accounts");

            modelBuilder.Entity<Customer>().HasData(new Customer { Id = Guid.Parse("4E18E003-5FD2-438E-95C6-C8142166F7DB"), FirstName = "Sam", LastName = "Johnes", Email = "sam.johnes@gmail.com", UserName = "john", Password = "password", DateOfBirth = DateTime.Parse("1993-03-02")});

            modelBuilder.Entity<Account>().HasData(new Account { Id = Guid.Parse("C1ACF3A0-CECD-4F5A-82B8-356805FEBE06"), Type = Enums.AccountType.Current, Balance = 3000 });

            modelBuilder.Entity<Account>().HasData(new Account { Id = Guid.Parse("80E8FC35-48AE-41B3-962F-DA4D1B64B444"), Type = Enums.AccountType.Savings, Balance = 400000 });

            modelBuilder.Entity<CustomerAccount>().HasData(new CustomerAccount { CustomerId = Guid.Parse("4E18E003-5FD2-438E-95C6-C8142166F7DB"), AccountId = Guid.Parse("C1ACF3A0-CECD-4F5A-82B8-356805FEBE06") });
            modelBuilder.Entity<CustomerAccount>().HasData(new CustomerAccount { CustomerId = Guid.Parse("4E18E003-5FD2-438E-95C6-C8142166F7DB"), AccountId = Guid.Parse("80E8FC35-48AE-41B3-962F-DA4D1B64B444")});
        }
    }
}
