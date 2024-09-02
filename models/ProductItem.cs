namespace InventoryManagement.Models
{
    public class ProductItem
    {
        public int Id {get; set;}
        public int ProductId {get; set;}
        public Product Product {get; set;} = null!;
        public int VariationId {get; set;}
        public Variation Variation {get; set;} = null!;
        public int Quantity {get; set;}
    }
}