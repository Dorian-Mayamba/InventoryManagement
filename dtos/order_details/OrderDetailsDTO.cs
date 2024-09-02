using InventoryManagement.Dtos.Orders;
using InventoryManagement.Dtos.Products;

namespace InventoryManagement.Dtos.OrderDetails
{
    public class OrderDetailsDto
    {
        public int Id { get; set;}
        public ProductDTO Product {get; set;} = null!;
        public int Quantity { get; set; }
    }
}