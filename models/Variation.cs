namespace InventoryManagement.Models
{
    public class Variation
    {
        public int Id {get; set;}
        public int CategoryId {get; set;}
        public Category Category {get; set;} = null!;

        public int SizeId {get; set;}
        public Size Size {get; set;} = null!;         
        public ICollection<ProductItem> ProductItems {get; set;} = null!;
    }
}