using InventoryManagement.Dtos.OrderDetails;
using InventoryManagement.Dtos.Products;

namespace InventoryManagement.Dtos.Orders
{
    public record AddOrderDTO(decimal TotalPrice, ICollection<OrderDetailsDto> OrderDetails);
}