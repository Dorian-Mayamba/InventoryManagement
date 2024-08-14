namespace InventoryManagement.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Role> roles {get; set;}

        public DbSet<Customer> customers {get; set;}

        public DbSet<Admin> admins {get; set;}
    }
}