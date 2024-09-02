using AutoMapper;
using InventoryManagement.Dtos.Products;
namespace InventoryManagement.AutoMapperProfiles
{
    public class ProductProfiles: Profile
    {
        public ProductProfiles()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<AddProductDTO, Product>();
            CreateMap<EditProductDTO, Product>();
        }
    }
}