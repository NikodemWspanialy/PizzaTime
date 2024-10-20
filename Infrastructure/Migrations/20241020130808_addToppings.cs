using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addToppings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { "1150992c-7639-401c-8a4b-c463764e49a0", "Peperoni", 5.0, },
                    { "432ee021-ff88-4391-86ad-b119ac68a763", "Mozzarella", 5.0 },
                    { "c4399f09-95e4-4009-b632-f303200f6f86", "Brocoli", 6.0 },
                    { "e954f588-e44d-4d4d-9f15-673d8c78dfe8", "Chicken", 4.0 },
                    { "ee2fed01-8e15-4b3c-ae3d-306de8a0fe96", "Cheese", 3.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "1150992c-7639-401c-8a4b-c463764e49a0");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "432ee021-ff88-4391-86ad-b119ac68a763");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "c4399f09-95e4-4009-b632-f303200f6f86");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "e954f588-e44d-4d4d-9f15-673d8c78dfe8");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "ee2fed01-8e15-4b3c-ae3d-306de8a0fe96");
        }
    }
}
