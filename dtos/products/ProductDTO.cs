using InventoryManagement.Dtos.Categories;
using InventoryManagement.Dtos.Sales;

namespace InventoryManagement.Dtos.Products
{
    public record ProductDTO(int Id, string Name, CategoryDTO category, decimal Price,string ProductPicture, InventoryDTO Inventory, ICollection<SalesDTO> Sales);
}