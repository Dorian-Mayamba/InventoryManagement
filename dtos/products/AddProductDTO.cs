using InventoryManagement.Dtos.Categories;
using InventoryManagement.Dtos.Inventories;

namespace InventoryManagement.Dtos.Products
{
    public record AddProductDTO(string Name, CategoryDTO Category, string ProductPicture, decimal Price, AddInventoryDTO Inventory);
}