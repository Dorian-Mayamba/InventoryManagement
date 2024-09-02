using InventoryManagement.Dtos.OrderDetails;

namespace InventoryManagement.Dtos.Orders
{
    public record OrderDTO(int Id, decimal TotalPrice, DateTime CreatedAt, ICollection<OrderDetailsDto> OrdersDetails);
}