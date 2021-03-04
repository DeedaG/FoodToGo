using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodToGo.Migrations
{
    public partial class Item_Price_Discount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Item",
                type: "DECIMAL",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Item",
                type: "DECIMAL",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Item");
        }
    }
}
