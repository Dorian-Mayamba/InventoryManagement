using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasMany(c=>c.Orders)
            .WithOne(o=>o.Customer)
            .HasForeignKey(o => o.CustomerId);

            builder.HasData(
                new Customer {Id = 1, Name = "John Doe", Email="John.Doe@gmail.com", Password="123123", RoleId = 2}
            );
        }
    }
}