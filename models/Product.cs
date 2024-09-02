namespace InventoryManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string ProductPicture { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
        public ICollection<ProductItem> ProductItems {get; set;} = null!;
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; } = null!;
    }
}