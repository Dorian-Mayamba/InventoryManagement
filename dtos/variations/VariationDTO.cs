using InventoryManagement.Dtos.Categories;

namespace InventoryManagement.Dtos.Variations
{
    public class VariationDTO
    {
        public int Id {get; set;}
        public CategoryDTO Category {get; set;} = null!;
        public SizeDTO Size {get; set;} = null!;
    }
}