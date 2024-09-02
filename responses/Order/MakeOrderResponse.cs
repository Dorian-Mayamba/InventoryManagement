using InventoryManagement.Dtos.Orders;

namespace InventoryManagement.Response.Order
{
    public class MakeOrderResponse
    {
        public string Message {get; set;} = null!;

        public OrderDTO Order {get; set;} = null!;
    }
}