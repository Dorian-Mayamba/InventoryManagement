namespace InventoryManagement.Dtos.Orders
{
    public record OrderDTO(int Id, decimal TotalPrice, DateTime CreatedAt);
}