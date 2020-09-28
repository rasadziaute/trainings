using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyOnlineShopping.Migrations
{
    public partial class doubletn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "ShoppingCartItem",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "ShoppingCartItem",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
