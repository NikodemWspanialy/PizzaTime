using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addNormalizeNameToToppingsInDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "NormalizeName",
                table: "toppings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "toppings",
                columns: new[] { "Id", "IsAvailable", "Name", "NormalizeName", "Price" },
                values: new object[,]
                {
                    { "87ae51f3-6822-4a19-9c81-7c3914cb168f", true, "Mozzarella", "MOZZARELLA", 5.0 },
                    { "dae542a0-431c-49c8-9cb3-f990d8fb7157", true, "Brocoli", "BROCOLI", 6.0 },
                    { "f4957472-4dec-4bfa-824b-95102ac7f1a1", true, "Peperoni", "PEPERONI", 5.0 },
                    { "fc15e9b6-b1da-4a0c-84da-f2e0e8376f73", true, "Cheese", "CHEESE", 3.0 },
                    { "fd46778b-e165-47ff-a8d7-3d11ecf0404c", true, "Chicken", "CHICKEN", 4.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "87ae51f3-6822-4a19-9c81-7c3914cb168f");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "dae542a0-431c-49c8-9cb3-f990d8fb7157");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "f4957472-4dec-4bfa-824b-95102ac7f1a1");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "fc15e9b6-b1da-4a0c-84da-f2e0e8376f73");

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "Id",
                keyValue: "fd46778b-e165-47ff-a8d7-3d11ecf0404c");

            migrationBuilder.DropColumn(
                name: "NormalizeName",
                table: "toppings");

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
    }
}
