using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class StoreConfig : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasMany(s=>s.Inventories)
            .WithOne(i=>i.Store)
            .HasForeignKey(i=>i.StoreId);

            builder.HasData(
                new Store {Id= 1, Name = "DripGames", LocationId = 1},
                new Store {Id= 2, Name = "DripGames", LocationId = 2},
                new Store {Id= 3, Name = "DripGames", LocationId = 3},
                new Store {Id= 4, Name = "DripGames", LocationId = 4}
            );
        }
    }
}