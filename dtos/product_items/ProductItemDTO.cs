using InventoryManagement.Dtos.Products;
using InventoryManagement.Dtos.Variations;

namespace InventoryManagement.Dtos.ProductItems
{
    public class ProductItemDTO
    {
        public int Id {get; set;}
        public ProductDTO Product {get; set;} = null!;
        public VariationDTO Variation {get; set;} = null!;
        public int Quantity {get; set;}
    }
}