using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAccount",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(nullable: false),
                    AccountId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAccount", x => new { x.CustomerId, x.AccountId });
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "AccountId", "Balance", "Type" },
                values: new object[,]
                {
                    { new Guid("c1acf3a0-cecd-4f5a-82b8-356805febe06"), 3000.0, 1 },
                    { new Guid("80e8fc35-48ae-41b3-962f-da4d1b64b444"), 400000.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "DateOfBirth", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { new Guid("4e18e003-5fd2-438e-95c6-c8142166f7db"), new DateTime(1993, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam.johnes@gmail.com", "Sam", "Johnes", "password", "john" });

            migrationBuilder.InsertData(
                table: "CustomerAccount",
                columns: new[] { "CustomerId", "AccountId" },
                values: new object[,]
                {
                    { new Guid("4e18e003-5fd2-438e-95c6-c8142166f7db"), new Guid("c1acf3a0-cecd-4f5a-82b8-356805febe06") },
                    { new Guid("4e18e003-5fd2-438e-95c6-c8142166f7db"), new Guid("80e8fc35-48ae-41b3-962f-da4d1b64b444") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "CustomerAccount");
        }
    }
}
