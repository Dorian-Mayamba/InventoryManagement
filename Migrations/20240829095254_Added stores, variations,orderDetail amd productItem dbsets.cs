using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddedstoresvariationsorderDetailamdproductItemdbsets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_Store_StoreId",
                table: "inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_orders_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_products_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_Variation_VariationId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_products_ProductId",
                table: "ProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Users_CustomerId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_Location_LocationId",
                table: "Store");

            migrationBuilder.DropForeignKey(
                name: "FK_Variation_categories_CategoryId",
                table: "Variation");

            migrationBuilder.DropIndex(
                name: "IX_products_CustomerId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Variation",
                table: "Variation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductItem",
                table: "ProductItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "products");

            migrationBuilder.RenameTable(
                name: "Variation",
                newName: "variations");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "stores");

            migrationBuilder.RenameTable(
                name: "ProductItem",
                newName: "productItems");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "orderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_Variation_CategoryId",
                table: "variations",
                newName: "IX_variations_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Store_LocationId",
                table: "stores",
                newName: "IX_stores_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_VariationId",
                table: "productItems",
                newName: "IX_productItems_VariationId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductItem_ProductId",
                table: "productItems",
                newName: "IX_productItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_ProductId",
                table: "orderDetails",
                newName: "IX_orderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderId",
                table: "orderDetails",
                newName: "IX_orderDetails_OrderId");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "orders",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_variations",
                table: "variations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stores",
                table: "stores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productItems",
                table: "productItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_stores_StoreId",
                table: "inventories",
                column: "StoreId",
                principalTable: "stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_orders_OrderId",
                table: "orderDetails",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_products_ProductId",
                table: "orderDetails",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productItems_products_ProductId",
                table: "productItems",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productItems_variations_VariationId",
                table: "productItems",
                column: "VariationId",
                principalTable: "variations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stores_Location_LocationId",
                table: "stores",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_variations_categories_CategoryId",
                table: "variations",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_stores_StoreId",
                table: "inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_orders_OrderId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_products_ProductId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_productItems_products_ProductId",
                table: "productItems");

            migrationBuilder.DropForeignKey(
                name: "FK_productItems_variations_VariationId",
                table: "productItems");

            migrationBuilder.DropForeignKey(
                name: "FK_stores_Location_LocationId",
                table: "stores");

            migrationBuilder.DropForeignKey(
                name: "FK_variations_categories_CategoryId",
                table: "variations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_variations",
                table: "variations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stores",
                table: "stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productItems",
                table: "productItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails");

            migrationBuilder.RenameTable(
                name: "variations",
                newName: "Variation");

            migrationBuilder.RenameTable(
                name: "stores",
                newName: "Store");

            migrationBuilder.RenameTable(
                name: "productItems",
                newName: "ProductItem");

            migrationBuilder.RenameTable(
                name: "orderDetails",
                newName: "OrderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_variations_CategoryId",
                table: "Variation",
                newName: "IX_Variation_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_stores_LocationId",
                table: "Store",
                newName: "IX_Store_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_productItems_VariationId",
                table: "ProductItem",
                newName: "IX_ProductItem_VariationId");

            migrationBuilder.RenameIndex(
                name: "IX_productItems_ProductId",
                table: "ProductItem",
                newName: "IX_ProductItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_ProductId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_OrderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Variation",
                table: "Variation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductItem",
                table: "ProductItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CustomerId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_products_CustomerId",
                table: "products",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_Store_StoreId",
                table: "inventories",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_orders_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_products_ProductId",
                table: "OrderDetail",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Variation_VariationId",
                table: "ProductItem",
                column: "VariationId",
                principalTable: "Variation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_products_ProductId",
                table: "ProductItem",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Users_CustomerId",
                table: "products",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_Location_LocationId",
                table: "Store",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Variation_categories_CategoryId",
                table: "Variation",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
