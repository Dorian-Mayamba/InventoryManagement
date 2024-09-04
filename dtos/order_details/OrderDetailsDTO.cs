using InventoryManagement.Dtos.Orders;
using InventoryManagement.Dtos.Products;

namespace InventoryManagement.Dtos.OrderDetails
{
    public class OrderDetailsDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}