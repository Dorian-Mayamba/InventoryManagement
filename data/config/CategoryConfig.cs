using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "electronics" },
                new Category {Id = 2, Name = "jewelery"},
                new Category {Id = 3, Name = "men's clothing"},
                new Category {Id = 4, Name = "women's clothing"}
            );
        }
    }
}