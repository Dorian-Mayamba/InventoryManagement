using System.Runtime.CompilerServices;

namespace InventoryManagement.Dtos
{
    public record EditCustomerDTO(int Id, string Name, string Email, string Password);
}