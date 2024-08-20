using InventoryManagement.Dtos.Products;

namespace InventoryManagement.Dtos.Sales
{
    public record SalesDTO(int Id, int ProductId, ProductDTO Product);
}