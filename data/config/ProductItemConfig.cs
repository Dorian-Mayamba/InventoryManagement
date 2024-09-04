using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class ProductItemConfig : IEntityTypeConfiguration<ProductItem>
    {
        public void Configure(EntityTypeBuilder<ProductItem> builder)
        {
            builder.HasOne(p=>p.Variation)
            .WithMany(v=>v.ProductItems)
            .HasForeignKey(p => p.VariationId);
            builder.HasData(
                new ProductItem {Id = 1, ProductId = 1, VariationId = 1, Quantity = 20},
                new ProductItem {Id = 2, ProductId = 1, VariationId = 2, Quantity = 20},
                new ProductItem {Id = 3, ProductId = 1, VariationId = 3, Quantity = 20},
                new ProductItem {Id = 4, ProductId = 1, VariationId = 4, Quantity = 20},
                new ProductItem {Id = 5, ProductId = 1, VariationId = 5, Quantity = 20},
                new ProductItem {Id = 6, ProductId = 2, VariationId =1, Quantity = 20},
                new ProductItem {Id = 7, ProductId = 2, VariationId =2, Quantity = 20},
                new ProductItem {Id = 8, ProductId = 2, VariationId =3, Quantity = 20},
                new ProductItem {Id = 9, ProductId = 2, VariationId =4, Quantity = 20},
                new ProductItem {Id = 10, ProductId = 2, VariationId =5, Quantity = 20},
                new ProductItem {Id = 11, ProductId = 3, VariationId =1, Quantity = 20},
                new ProductItem {Id = 12, ProductId = 3, VariationId =2, Quantity = 20},
                new ProductItem {Id = 13, ProductId = 3, VariationId =3, Quantity = 20},
                new ProductItem {Id = 14, ProductId = 3, VariationId =4, Quantity = 20},
                new ProductItem {Id = 15, ProductId = 3, VariationId =5, Quantity = 20},
                new ProductItem {Id = 16, ProductId=4, VariationId=1, Quantity = 20},
                new ProductItem {Id = 17, ProductId=4, VariationId=2, Quantity = 20},
                new ProductItem {Id = 18, ProductId=4, VariationId=3, Quantity = 20},
                new ProductItem {Id = 19, ProductId=4, VariationId=4, Quantity = 20},
                new ProductItem {Id = 20, ProductId=4, VariationId=5, Quantity = 20},
                new ProductItem {Id = 21, ProductId=15, VariationId=6, Quantity = 20},
                new ProductItem {Id = 22, ProductId=15, VariationId=7, Quantity = 20},
                new ProductItem {Id = 23, ProductId=15, VariationId=8, Quantity = 20},
                new ProductItem {Id = 24, ProductId=15, VariationId=9, Quantity = 20},
                new ProductItem {Id = 25, ProductId=15, VariationId=10, Quantity = 20},
                new ProductItem {Id = 26, ProductId=16, VariationId=6, Quantity = 20},
                new ProductItem {Id = 27, ProductId=16, VariationId=7, Quantity = 20},
                new ProductItem {Id = 28, ProductId=16, VariationId=8, Quantity = 20},
                new ProductItem {Id = 29, ProductId=16, VariationId=9, Quantity = 20},
                new ProductItem {Id = 30, ProductId=16, VariationId=10, Quantity = 20},
                new ProductItem {Id = 31, ProductId = 17, VariationId =6, Quantity = 20},
                new ProductItem {Id = 32, ProductId = 17, VariationId =7, Quantity = 20},
                new ProductItem {Id = 33, ProductId = 17, VariationId =8, Quantity = 20},
                new ProductItem {Id = 34, ProductId = 17, VariationId =9, Quantity = 20},
                new ProductItem {Id = 35, ProductId = 17, VariationId =10, Quantity = 20},
                new ProductItem {Id = 36, ProductId = 18, VariationId =6, Quantity = 20},
                new ProductItem {Id = 37, ProductId = 18, VariationId =7, Quantity = 20},
                new ProductItem {Id = 38, ProductId = 18, VariationId =8, Quantity = 20},
                new ProductItem {Id = 39, ProductId = 18, VariationId =9, Quantity = 20},
                new ProductItem {Id = 40, ProductId = 18, VariationId =10, Quantity = 20},
                new ProductItem {Id = 41, ProductId = 19, VariationId =6, Quantity = 20},
                new ProductItem {Id = 42, ProductId = 19, VariationId =7, Quantity = 20},
                new ProductItem {Id = 43, ProductId = 19, VariationId =8, Quantity = 20},
                new ProductItem {Id = 44, ProductId = 19, VariationId =9, Quantity = 20},
                new ProductItem {Id = 45, ProductId = 19, VariationId =10, Quantity = 20},
                new ProductItem {Id = 46, ProductId = 20, VariationId =6, Quantity = 20},
                new ProductItem {Id = 48, ProductId = 20, VariationId =7, Quantity = 20},
                new ProductItem {Id = 49, ProductId = 20, VariationId =8, Quantity = 20},
                new ProductItem {Id = 50, ProductId = 20, VariationId =9, Quantity = 20},
                new ProductItem {Id = 51, ProductId = 20, VariationId =10, Quantity = 20}
            );
        }
    }
}