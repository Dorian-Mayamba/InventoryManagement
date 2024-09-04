using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class addedanewdefaultcustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "RoleId", "UserType" },
                values: new object[] { 1, "John.Doe@gmail.com", "John Doe", "123123", 2, 2 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "VariationId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 15, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 15, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 15, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 15, 10 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "VariationId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 16, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 16, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 16, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 16, 10 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "VariationId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 17, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 17, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 17, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 17, 10 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "VariationId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 18, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 18, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 18, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 18, 10 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "VariationId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 19, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 19, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 19, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 19, 10 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "VariationId",
                value: 6);

            migrationBuilder.InsertData(
                table: "productItems",
                columns: new[] { "Id", "ProductId", "Quantity", "VariationId" },
                values: new object[,]
                {
                    { 16, 4, 20, 1 },
                    { 48, 20, 20, 7 },
                    { 49, 20, 20, 8 },
                    { 50, 20, 20, 9 },
                    { 51, 20, 20, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 15, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 15, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 15, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "VariationId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 16, 6 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 16, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 16, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 16, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "VariationId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 17, 6 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 17, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 17, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 17, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "VariationId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 18, 6 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 18, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 18, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 18, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "VariationId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 19, 6 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 19, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 19, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 19, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "VariationId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 20, 6 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 20, 7 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 20, 8 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "VariationId" },
                values: new object[] { 20, 9 });

            migrationBuilder.UpdateData(
                table: "productItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "VariationId",
                value: 10);
        }
    }
}
