namespace InventoryManagement.Models
{
    public class Product
    {
        public int Id {get; set;}

        public int ProductDetailId {get; set;}

        public ProductDetail productDetail {get; set;} = null!;

        public int CategoryId {get; set;}

        public Category category {get; set;} = null!;

        public ICollection<Sale> Sales {get; set;} = null!;

        public ICollection<Inventory> Inventories {get; set;} = null!;

        public ICollection<Customer> Customers {get; set;} = null!;
        
    }
}