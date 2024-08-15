
namespace InventoryManagement.Models
{
    public class Purchase
    {
        public int Id { get; set;}

        public int OrderId {get; set;}

        public Order order {get; set;} = null!;

        public decimal TotalPrice {get; set;}

        public DateTime PurchaseDate {get; set;}

    }
}