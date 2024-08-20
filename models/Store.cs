namespace InventoryManagement.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int LocationId {get; set;}
        public Location Location {get; set;} = null!;
    }
}