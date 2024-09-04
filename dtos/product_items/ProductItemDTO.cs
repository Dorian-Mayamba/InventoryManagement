using InventoryManagement.Dtos.Products;
using InventoryManagement.Dtos.Variations;

namespace InventoryManagement.Dtos.ProductItems
{
    public class ProductItemDTO
    {
        public int Id {get; set;}
        public int ProductId {get; set;}
        public VariationDTO Variation {get; set;} = null!;
        public int Quantity {get; set;}
    }
}