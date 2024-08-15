namespace InventoryManagement.Models
{
    public class Order
    {
        public int Id { get; set;}
        public int TotalAmount {get; set;}

        public int CustomerId {get; set;}
        public Customer customer {get; set;} = null!;

        public ICollection<Purchase> Purchases {get; set;} = null!;
        public DateTime CreatedAt {get; set;}
    }
}