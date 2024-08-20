using AutoMapper;
namespace InventoryManagement.AutoMapperProfiles
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            CreateMap<AddCustomerDTO, Customer>();
            CreateMap<EditCustomerDTO,Customer>();
            CreateMap<Customer, CustomerDTO>();
        }
    }
}