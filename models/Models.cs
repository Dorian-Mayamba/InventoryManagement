namespace InventoryManagement.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Role_Id { get; set; }



    }


    public class Role{
        [Key]
        public int Id {get; set;}

        public string Type { get; set;} = null!;
    }

    public class Admin{
        [Key]
        public int Id {get; set;}

        [Required]
        public string UserName {get; set;} = null!;

        [Required]
        public string email {get; set;} = null!;

        [Required]
        public string password {get; set;} = null!;

    }

    
}

