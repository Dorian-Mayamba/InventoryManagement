using InventoryManagement.Dtos.Inventories;
using InventoryManagement.Dtos.Products;

namespace InventoryManagement.Dtos
{
    public record InventoryDTO(int Id, int ProductId, int Quantity);
}