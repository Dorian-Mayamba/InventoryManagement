using System.Runtime.CompilerServices;
using InventoryManagement.Dtos.Orders;
using InventoryManagement.Dtos.Products;

namespace InventoryManagement.Dtos
{
    public record CustomerDTO(int Id, string Name, string Email, ICollection<OrderDTO> Orders, ICollection<ProductDTO> Products);
}