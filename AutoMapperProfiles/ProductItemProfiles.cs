using AutoMapper;
using InventoryManagement.Dtos.ProductItems;
namespace InventoryManagement.AutoMapperProfiles
{
    public class ProductItemProfiles:Profile
    {
        public ProductItemProfiles()
        {
            CreateMap<ProductItem, ProductItemDTO>();
            CreateMap<AddProductItemDTO, ProductItem>();
            CreateMap<EditProductItemDTO, ProductItem>();
        }
    }
}