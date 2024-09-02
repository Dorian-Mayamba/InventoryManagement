using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddedaSizetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                table: "variations",
                newName: "SizeId");

            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" },
                    { 6, "XXL" }
                });

            migrationBuilder.UpdateData(
                table: "variations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "SizeId" },
                values: new object[] { 3, 6 });

            migrationBuilder.InsertData(
                table: "variations",
                columns: new[] { "Id", "CategoryId", "SizeId" },
                values: new object[] { 11, 4, 6 });

            migrationBuilder.CreateIndex(
                name: "IX_variations_SizeId",
                table: "variations",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_variations_sizes_SizeId",
                table: "variations",
                column: "SizeId",
                principalTable: "sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_variations_sizes_SizeId",
                table: "variations");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropIndex(
                name: "IX_variations_SizeId",
                table: "variations");

            migrationBuilder.DeleteData(
                table: "variations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.RenameColumn(
                name: "SizeId",
                table: "variations",
                newName: "Size");

            migrationBuilder.UpdateData(
                table: "variations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Size" },
                values: new object[] { 4, 1 });
        }
    }
}
