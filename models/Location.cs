namespace InventoryManagement.Models
{
    public class Location
    {
        public int Id {get; set;}
        
        public int AddressId {get; set;}
        public LocationAddress LocationAddress {get;set;} = null!;

    }
}