using AutoMapper;
using InventoryManagement.Dtos.Orders;

namespace InventoryManagement.AutoMapperProfiles
{
    public class OrderProfiles:Profile
    {
        public OrderProfiles()
        {
            CreateMap<Order, OrderDTO>();
            CreateMap<AddOrderDTO, Order>();
            CreateMap<EditOrderDTO, Order>();
        }
    }
}