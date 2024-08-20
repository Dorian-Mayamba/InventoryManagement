namespace InventoryManagement.Dtos.Products
{
    public record EditProductDTO(string Name, string ProductPicture, decimal Price, InventoryDTO Inventory);
}