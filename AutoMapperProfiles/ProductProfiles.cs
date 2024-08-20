using AutoMapper;
using InventoryManagement.Dtos.Products;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
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