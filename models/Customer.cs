namespace InventoryManagement.Models
{
    public class Customer:User
    {
           public ICollection<Order> Orders {get; set;} = null!;        
    }
}