using AutoMapper;
using InventoryManagement.Dtos.Variations;

namespace InventoryManagement.AutoMapperProfiles
{
    public class VariationProfiles:Profile
    {
        public VariationProfiles()
        {
            CreateMap<Variation,VariationDTO>();
        }
    }
}