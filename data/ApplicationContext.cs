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
            modelBuilder.Entity<LocationAddress>().HasData(
                new LocationAddress {Id = 1, City = "London", Country = "United Kingdom", LocationId = 1},
                new LocationAddress {Id = 2, City = "London", Country = "United Kingdom", LocationId = 2},
                new LocationAddress {Id = 3, City = "London", Country = "United Kingdom", LocationId = 3},
                new LocationAddress {Id = 4, City = "London", Country = "United Kingdom", LocationId = 4}
            );
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
        public DbSet<ProductItem> productItems {get; set;}
        public DbSet<Variation> variations {get; set;}
        public DbSet<OrderDetail> orderDetails {get;set;}
        public DbSet<Store> stores {get; set;}

        public DbSet<Size> sizes {get; set;}
    }
}