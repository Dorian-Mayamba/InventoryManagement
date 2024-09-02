using AutoMapper;

namespace InventoryManagement.AutoMapperProfiles
{
    public class SizeProfiles:Profile
    {
        public SizeProfiles()
        {
            CreateMap<Size, SizeDTO>();
        }
    }
}