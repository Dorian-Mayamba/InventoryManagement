using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class Addednewmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LocationAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationAddress", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_LocationAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "LocationAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Store_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventories_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchases_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ProductPicture = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "LocationAddress",
                columns: new[] { "Id", "City", "Country", "LocationId" },
                values: new object[,]
                {
                    { 1, "London", "United Kingdom", 1 },
                    { 2, "London", "United Kingdom", 2 },
                    { 3, "London", "United Kingdom", 3 },
                    { 4, "London", "United Kingdom", 4 }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "electronics" },
                    { 2, "jewelery" },
                    { 3, "men's clothing" },
                    { 4, "women's clothing" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "AddressId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "DripGames" },
                    { 2, 2, "DripGames" },
                    { 3, 3, "DripGames" },
                    { 4, 4, "DripGames" }
                });

            migrationBuilder.InsertData(
                table: "inventories",
                columns: new[] { "Id", "ProductId", "Quantity", "StoreId" },
                values: new object[,]
                {
                    { 1, 1, 100, 1 },
                    { 2, 2, 100, 2 },
                    { 3, 3, 100, 3 },
                    { 4, 4, 100, 4 },
                    { 5, 5, 100, 1 },
                    { 6, 6, 100, 2 },
                    { 7, 7, 100, 3 },
                    { 8, 8, 100, 4 },
                    { 9, 9, 100, 1 },
                    { 10, 10, 100, 2 },
                    { 11, 11, 100, 3 },
                    { 12, 12, 100, 4 },
                    { 13, 13, 100, 1 },
                    { 14, 14, 100, 2 },
                    { 15, 15, 100, 3 },
                    { 16, 16, 100, 4 },
                    { 17, 17, 100, 1 },
                    { 18, 18, 100, 2 },
                    { 19, 19, 100, 3 },
                    { 20, 20, 100, 4 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "CustomerId", "InventoryId", "Name", "Price", "ProductPicture" },
                values: new object[,]
                {
                    { 1, 3, null, 1, "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", 109.95m, "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg" },
                    { 2, 3, null, 2, "Mens Casual Premium Slim Fit T-Shirts", 22.3m, "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg" },
                    { 3, 3, null, 3, "Mens Cotton Jacket", 55.99m, "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg" },
                    { 4, 3, null, 4, "Mens Casual Slim Fit", 15.99m, "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg" },
                    { 5, 2, null, 5, "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet", 695m, "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg" },
                    { 6, 2, null, 6, "Solid Gold Petite Micropave", 168m, "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg" },
                    { 7, 2, null, 7, "White Gold Plated Princess", 9.99m, "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg" },
                    { 8, 2, null, 8, "Pierced Owl Rose Gold Plated Stainless Steel Double", 10.99m, "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg" },
                    { 9, 1, null, 9, "WD 2TB Elements Portable External Hard Drive - USB 3.0", 64m, "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg" },
                    { 10, 1, null, 10, "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s", 109m, "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg" },
                    { 11, 1, null, 11, "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5", 109m, "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg" },
                    { 12, 1, null, 12, "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive", 114m, "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg" },
                    { 13, 1, null, 13, "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin", 599m, "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg" },
                    { 14, 1, null, 14, "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA) – Super Ultrawide Screen QLED", 999.99m, "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg" },
                    { 15, 4, null, 15, "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats", 56.99m, "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg" },
                    { 16, 4, null, 16, "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket", 29.95m, "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg" },
                    { 17, 4, null, 17, "Rain Jacket Women Windbreaker Striped Climbing Raincoats", 39.99m, "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg" },
                    { 18, 4, null, 18, "MBJ Women's Solid Short Sleeve Boat Neck V", 9.85m, "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg" },
                    { 19, 4, null, 19, "Opna Women's Short Sleeve Moisture", 7.95m, "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg" },
                    { 20, 4, null, 20, "DANVOUY Womens T Shirt Casual Cotton Short", 12.99m, "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_inventories_ProductId",
                table: "inventories",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_inventories_StoreId",
                table: "inventories",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_AddressId",
                table: "Location",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_CustomerId",
                table: "orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CustomerId",
                table: "products",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_products_InventoryId",
                table: "products",
                column: "InventoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_purchases_OrderId",
                table: "purchases",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_LocationId",
                table: "Store",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "purchases");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "inventories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "LocationAddress");
        }
    }
}
