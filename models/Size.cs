namespace InventoryManagement.Models
{
    public class Size
    {
        public int Id {get; set;}

        public string Name {get; set;} = null!;

        public ICollection<Variation> Variations {get; set;} = null!;
    }
}