using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasOne(o=>o.Order)
            .WithMany(o=>o.OrderDetails)
            .HasForeignKey(o=>o.OrderId);

            builder.HasOne(o=>o.Product)
            .WithMany(p=>p.OrderDetails)
            .HasForeignKey(o=>o.ProductId);
        }
    }
}