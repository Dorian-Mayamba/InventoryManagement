using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o=>o.Customer)
            .WithMany(c=>c.Orders)
            .HasForeignKey(o=>o.CustomerId);
        }
    }
}