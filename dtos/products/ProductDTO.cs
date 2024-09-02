using InventoryManagement.Dtos.Categories;

namespace InventoryManagement.Dtos.Products
{
    public record ProductDTO(int Id, string Name, CategoryDTO category, decimal Price,string ProductPicture, InventoryDTO Inventory);
}