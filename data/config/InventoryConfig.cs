using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class InventoryConfig : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasIndex(e => e.ProductId)
            .IsUnique();
            builder.HasData(
                new Inventory { Id = 1, ProductId = 1, Quantity = 100 },  // ProductId 1
                new Inventory { Id = 2, ProductId = 2, Quantity = 100 },  // ProductId 2
                new Inventory { Id = 3, ProductId = 3, Quantity = 100 },  // ProductId 3
                new Inventory { Id = 4, ProductId = 4, Quantity = 100 },  // ProductId 4
                new Inventory { Id = 5, ProductId = 5, Quantity = 100 },  // ProductId 5
                new Inventory { Id = 6, ProductId = 6, Quantity = 100 },  // ProductId 6
                new Inventory { Id = 7, ProductId = 7, Quantity = 100 },  // ProductId 7
                new Inventory { Id = 8, ProductId = 8, Quantity = 100 },  // ProductId 8
                new Inventory { Id = 9, ProductId = 9, Quantity = 100 },  // ProductId 9
                new Inventory { Id = 10, ProductId = 10, Quantity = 100 }, // ProductId 10
                new Inventory { Id = 11, ProductId = 11, Quantity = 100 }, // ProductId 11
                new Inventory { Id = 12, ProductId = 12, Quantity = 100 }, // ProductId 12
                new Inventory { Id = 13, ProductId = 13, Quantity = 100 }, // ProductId 13
                new Inventory { Id = 14, ProductId = 14, Quantity = 100 }, // ProductId 14
                new Inventory { Id = 15, ProductId = 15, Quantity = 100 }, // ProductId 15
                new Inventory { Id = 16, ProductId = 16, Quantity = 100 }, // ProductId 16
                new Inventory { Id = 17, ProductId = 17, Quantity = 100 }, // ProductId 17
                new Inventory { Id = 18, ProductId = 18, Quantity = 100 }, // ProductId 18
                new Inventory { Id = 19, ProductId = 19, Quantity = 100 }, // ProductId 19
                new Inventory { Id = 20, ProductId = 20, Quantity = 100 }  // ProductId 20
            );
        }
    }
}