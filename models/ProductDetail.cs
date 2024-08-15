namespace InventoryManagement.Models
{
    public class ProductDetail
    {

        public int Id {get; set;}

        public string Name {get; set;} = null!;

        public string Brand {get; set;} = null!;

        public decimal Price {get; set;}

        public string ProductPicture {get; set;} = null!;

        public int ProductId {get;set;}
        public Product product {get; set;} = null!;

        public int Size {get; set;}
    }
}