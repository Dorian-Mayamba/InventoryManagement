using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class VariationConfig : IEntityTypeConfiguration<Variation>
    {
        public void Configure(EntityTypeBuilder<Variation> builder)
        {
            builder.HasOne(v=>v.Category)
            .WithMany(c=>c.Variations)
            .HasForeignKey(v=>v.CategoryId);

            builder.HasOne(v=>v.Size)
            .WithMany(s=>s.Variations)
            .HasForeignKey(v=>v.SizeId);

            builder.HasData(
                new Variation { Id = 1,  CategoryId = 3, SizeId = InventoryManagement.Enumerations.Size.XS.Id },
                new Variation { Id = 2,  CategoryId = 3, SizeId = InventoryManagement.Enumerations.Size.S.Id},
                new Variation { Id = 3,  CategoryId = 3, SizeId = InventoryManagement.Enumerations.Size.M.Id},
                new Variation { Id = 4,  CategoryId = 3, SizeId = InventoryManagement.Enumerations.Size.L.Id},
                new Variation { Id = 5,  CategoryId = 3, SizeId = InventoryManagement.Enumerations.Size.XL.Id},
                new Variation { Id = 6,  CategoryId = 3, SizeId = InventoryManagement.Enumerations.Size.XXL.Id},
                new Variation { Id = 7,  CategoryId = 4, SizeId = InventoryManagement.Enumerations.Size.S.Id},
                new Variation { Id = 8,  CategoryId = 4, SizeId = InventoryManagement.Enumerations.Size.M.Id},
                new Variation { Id = 9,  CategoryId = 4, SizeId = InventoryManagement.Enumerations.Size.L.Id},
                new Variation { Id = 10,  CategoryId = 4, SizeId = InventoryManagement.Enumerations.Size.XL.Id},
                new Variation { Id = 11,  CategoryId = 4, SizeId = InventoryManagement.Enumerations.Size.XXL.Id}
            );
        }
    }
}