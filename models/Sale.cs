namespace InventoryManagement.Models
{
    public class Sale
    {
        public int Id {get; set;}

        public int ProductId {get; set;}

        public Product product {get; set;} = null!;

        public DateTime CreatedAt {get; set;}
    }
}