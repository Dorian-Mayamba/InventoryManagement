using AutoMapper;
using InventoryManagement.Dtos.Sales;

namespace InventoryManagement.AutoMapperProfiles
{
    public class SalesProfile:Profile
    {
        public SalesProfile()
        {
            CreateMap<Sale, SalesDTO>();
        }
    }
}