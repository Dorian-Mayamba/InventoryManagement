using InventoryManagement.Dtos.Products;

namespace InventoryManagement.Dtos.Orders
{
    public record AddOrderDTO(decimal TotalPrice, IEnumerable<int> Basket);
}