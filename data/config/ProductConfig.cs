using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p=>p.productDetail)
            .WithOne(p => p.product)
            .HasForeignKey<ProductDetail>(pd=>pd.ProductId);
            
            builder.HasMany(p=>p.Sales)
            .WithOne(s=>s.product)
            .HasForeignKey(s=>s.ProductId);

            builder.HasMany(p => p.Inventories)
            .WithOne(i=>i.Product)
            .HasForeignKey(i=>i.ProductId);

            builder.HasOne(p=>p.category)
            .WithMany(c=>c.Products)
            .HasForeignKey(p=>p.CategoryId);
        }
    }
}