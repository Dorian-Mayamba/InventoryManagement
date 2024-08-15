using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasMany(c=>c.Products)
            .WithMany(p=>p.Customers)
            .UsingEntity(j => j.ToTable("CustomerProducts"));
        }
    }
}