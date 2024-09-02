namespace InventoryManagement.Models
{
    public class LocationAddress
    {
        public int Id {get; set;}
        public string City {get; set;} = null!;
        public string Country {get;set;} = null!;

        public Location Location {get; set;} = null!;

        public int LocationId {get; set;}
    }
}