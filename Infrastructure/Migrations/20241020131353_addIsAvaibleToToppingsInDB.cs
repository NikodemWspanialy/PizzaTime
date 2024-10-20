using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addIsAvaibleToToppingsInDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "toppings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "toppings",
                columns: new[] { "Id", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { "3e0bd924-00c9-4ce6-a058-2dc937f22509", true, "Mozzarella", 5.0 },
                    { "50250a97-b8a6-42c6-84c9-78c0b1d09dbd", true, "Cheese", 3.0 },
                    { "a366f09d-235d-48d1-bc68-59678be36c2b", true, "Brocoli", 6.0 },
                    { "b9db8de8-f29a-4e27-b4a3-88c22bd77a71", true, "Peperoni", 5.0 },
                    { "c190c4e2-ff84-4f9a-ba48-b03054e54801", true, "Chicken", 4.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "3e0bd924-00c9-4ce6-a058-2dc937f22509");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "50250a97-b8a6-42c6-84c9-78c0b1d09dbd");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "a366f09d-235d-48d1-bc68-59678be36c2b");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "b9db8de8-f29a-4e27-b4a3-88c22bd77a71");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "c190c4e2-ff84-4f9a-ba48-b03054e54801");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "toppings");

            migrationBuilder.InsertData(
                table: "toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { "1150992c-7639-401c-8a4b-c463764e49a0", "Peperoni", 5.0 },
                    { "432ee021-ff88-4391-86ad-b119ac68a763", "Mozzarella", 5.0 },
                    { "c4399f09-95e4-4009-b632-f303200f6f86", "Brocoli", 6.0 },
                    { "e954f588-e44d-4d4d-9f15-673d8c78dfe8", "Chicken", 4.0 },
                    { "ee2fed01-8e15-4b3c-ae3d-306de8a0fe96", "Cheese", 3.0 }
                });
        }
    }
}
