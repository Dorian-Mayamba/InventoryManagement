using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasMany(l=>l.Stores)
            .WithOne(s=>s.Location)
            .HasForeignKey(s=>s.LocationId);

            builder.HasOne(l=>l.LocationAddress)
            .WithOne(a=>a.Location)
            .HasForeignKey<Location>(l=>l.AddressId);

            builder.HasData(
                new Location {Id = 1, AddressId = 1 },
                new Location {Id = 2, AddressId = 2 },
                new Location {Id = 3, AddressId = 3 },
                new Location {Id = 4 , AddressId = 4 }
            );
        }
    }
}