using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o=>o.customer)
            .WithMany(c=>c.Orders)
            .HasForeignKey(o=>o.CustomerId);

            builder.HasMany(o=>o.Purchases)
            .WithOne(p=>p.order)
            .HasForeignKey(p=>p.OrderId);
        }
    }
}