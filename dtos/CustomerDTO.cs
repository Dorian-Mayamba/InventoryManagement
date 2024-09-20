using System.Runtime.CompilerServices;
using InventoryManagement.Dtos.Orders;
using InventoryManagement.Dtos.Products;

namespace InventoryManagement.Dtos
{
    public record CustomerDTO(string Id, string Email, ICollection<OrderDTO> Orders);
}