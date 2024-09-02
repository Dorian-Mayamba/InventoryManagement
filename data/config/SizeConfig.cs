using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Data.Config
{
    public class SizeConfig : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size {Id = InventoryManagement.Enumerations.Size.XS.Id, Name = InventoryManagement.Enumerations.Size.XS.Name},
                new Size {Id = InventoryManagement.Enumerations.Size.S.Id, Name = InventoryManagement.Enumerations.Size.S.Name},
                new Size {Id = InventoryManagement.Enumerations.Size.M.Id, Name = InventoryManagement.Enumerations.Size.M.Name},
                new Size {Id = InventoryManagement.Enumerations.Size.L.Id, Name = InventoryManagement.Enumerations.Size.L.Name},
                new Size {Id = InventoryManagement.Enumerations.Size.XL.Id, Name = InventoryManagement.Enumerations.Size.XL.Name},
                new Size {Id = InventoryManagement.Enumerations.Size.XXL.Id, Name = InventoryManagement.Enumerations.Size.XXL.Name}
            );
        }
    }
}