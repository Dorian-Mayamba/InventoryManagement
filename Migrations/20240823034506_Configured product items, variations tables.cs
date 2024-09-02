using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class Configuredproductitemsvariationstables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Variation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variation_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    VariationId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductItem_Variation_VariationId",
                        column: x => x.VariationId,
                        principalTable: "Variation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductItem_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Variation",
                columns: new[] { "Id", "CategoryId", "Size" },
                values: new object[,]
                {
                    { 1, 3, 1 },
                    { 2, 3, 2 },
                    { 3, 3, 3 },
                    { 4, 3, 4 },
                    { 5, 3, 5 },
                    { 6, 4, 1 },
                    { 7, 4, 2 },
                    { 8, 4, 3 },
                    { 9, 4, 4 },
                    { 10, 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductItem",
                columns: new[] { "Id", "ProductId", "Quantity", "VariationId" },
                values: new object[,]
                {
                    { 1, 2, 20, 1 },
                    { 2, 2, 20, 2 },
                    { 3, 2, 20, 3 },
                    { 4, 2, 20, 4 },
                    { 5, 2, 20, 5 },
                    { 6, 3, 20, 1 },
                    { 7, 3, 20, 2 },
                    { 8, 3, 20, 3 },
                    { 9, 3, 20, 4 },
                    { 10, 3, 20, 5 },
                    { 11, 4, 20, 1 },
                    { 12, 4, 20, 2 },
                    { 13, 4, 20, 3 },
                    { 14, 4, 20, 4 },
                    { 15, 4, 20, 5 },
                    { 17, 15, 20, 6 },
                    { 18, 15, 20, 7 },
                    { 19, 15, 20, 8 },
                    { 20, 15, 20, 9 },
                    { 21, 15, 20, 10 },
                    { 22, 16, 20, 6 },
                    { 23, 16, 20, 7 },
                    { 24, 16, 20, 8 },
                    { 25, 16, 20, 9 },
                    { 26, 16, 20, 10 },
                    { 27, 17, 20, 6 },
                    { 28, 17, 20, 7 },
                    { 29, 17, 20, 8 },
                    { 30, 17, 20, 9 },
                    { 31, 17, 20, 10 },
                    { 32, 18, 20, 6 },
                    { 33, 18, 20, 7 },
                    { 34, 18, 20, 8 },
                    { 35, 18, 20, 9 },
                    { 36, 18, 20, 10 },
                    { 37, 19, 20, 6 },
                    { 38, 19, 20, 7 },
                    { 39, 19, 20, 8 },
                    { 40, 19, 20, 9 },
                    { 41, 19, 20, 10 },
                    { 42, 20, 20, 6 },
                    { 43, 20, 20, 7 },
                    { 44, 20, 20, 8 },
                    { 45, 20, 20, 9 },
                    { 46, 20, 20, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_ProductId",
                table: "ProductItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_VariationId",
                table: "ProductItem",
                column: "VariationId");

            migrationBuilder.CreateIndex(
                name: "IX_Variation_CategoryId",
                table: "Variation",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductItem");

            migrationBuilder.DropTable(
                name: "Variation");
        }
    }
}
