namespace InventoryManagement.Models
{
    public class Order
    {
        public int Id { get; set;}
        public decimal TotalPrice {get; set;}
        public string CustomerId {get; set;} = null!;
        public Customer Customer {get; set;} = null!;
        public DateTime CreatedAt {get; set;}
        public ICollection<OrderDetail> OrderDetails {get; set;} = null!;
    }
}