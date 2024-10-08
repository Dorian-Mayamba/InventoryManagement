namespace InventoryManagement.Models
{
    public class Inventory
    {
        public int Id {get; set;}
        public int ProductId {get; set;}
        public Product Product {get; set;} = null!;
        public int StoreId {get;set;}
        public Store Store {get; set;} = null!;
        public int Quantity {get; set;} 
    }
}