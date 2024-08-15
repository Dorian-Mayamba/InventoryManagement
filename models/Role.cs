namespace InventoryManagement.Models
{
    public class Role{
        [Key]
        public int Id {get; set;}

        public string Type { get; set;} = null!;

        public ICollection<User> Users {get; set;} = null!;

    }
}