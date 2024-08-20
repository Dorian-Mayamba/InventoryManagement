using AutoMapper;
using InventoryManagement.Dtos.Categories;

namespace InventoryManagement.AutoMapperProfiles
{
    public class CategoryProfiles:Profile
    {
        public CategoryProfiles()
        {
            CreateMap<Category,CategoryDTO>();
            CreateMap<CategoryDTO,Category>();
            CreateMap<AddCategoryDTO,Category>();
            CreateMap<EditCategoryDTO,Category>();
        }
    }
}