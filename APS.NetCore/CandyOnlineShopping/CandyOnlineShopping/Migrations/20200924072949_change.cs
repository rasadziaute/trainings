using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyOnlineShopping.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartId",
                table: "ShoppingCartItem");

            migrationBuilder.AddColumn<string>(
                name: "ShoppingCartId",
                table: "ShoppingCartItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "ShoppingCartItem");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "ShoppingCartItem",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
