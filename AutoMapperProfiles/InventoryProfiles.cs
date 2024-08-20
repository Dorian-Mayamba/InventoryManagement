using AutoMapper;
using InventoryManagement.Dtos.Inventories;

namespace InventoryManagement.AutoMapperProfiles
{
    public class InventoryProfiles:Profile
    {
        public InventoryProfiles()
        {
            CreateMap<Inventory,InventoryDTO>();
            CreateMap<InventoryDTO, Inventory>();
            CreateMap<AddInventoryDTO,Inventory>();
            CreateMap<EditInventoryDTO,Inventory>();
        }
    }
}