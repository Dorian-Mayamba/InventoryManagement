namespace InventoryManagement.Models
{
    public class Order
    {
        public int Id { get; set;}
        public int TotalPrice {get; set;}
        public int CustomerId {get; set;}
        public Customer Customer {get; set;} = null!;
        public DateTime CreatedAt {get; set;}
        public ICollection<OrderDetail> OrderDetails {get; set;} = null!;
    }
}