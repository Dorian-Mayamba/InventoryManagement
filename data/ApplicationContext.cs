namespace InventoryManagement.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasDiscriminator<int>("UserType")
                .HasValue<Admin>(1)
                .HasValue<Customer>(2);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
        }

        public DbSet<Role> roles {get; set;}

        public DbSet<Customer> customers {get; set;}

        public DbSet<Admin> admins {get; set;}

        public DbSet<Category> categories {get; set;}

        public DbSet<Inventory> inventories {get; set;}

        public DbSet<Order> orders {get; set;}

        public DbSet<Purchase> purchases {get; set;}
        public DbSet<Product> products {get; set;}
        public DbSet<Sale> sales {get; set;}

    }


}