using AlugaJogos.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlugaJogos.Persistence
{
    internal class PropertieGroupConfiguration : IEntityTypeConfiguration<PropertyGroup>
    {
        public void Configure(EntityTypeBuilder<PropertyGroup> builder)
        {
            builder
                .HasIndex(p => p.Description)
                .IsUnique();

            builder
                .Property(p => p.Description)
                .IsRequired();

            builder
                .HasData(new PropertyGroup
                {
                    Id= 1,
                    Description = "Main",
                    Order = 1,
                });

            builder
                .HasData(new PropertyGroup
                {
                    Id = 2,
                    Description = "Properties",
                    Order = 2,
                });

            builder
                .HasData(new PropertyGroup
                {
                    Id = 3,
                    Description = "Images",
                    Order = 3,
                });

            builder
                .HasData(new PropertyGroup
                {
                    Id = 4,
                    Description = "Videos",
                    Order = 4,
                });

            builder
                .HasData(new PropertyGroup
                {
                    Id = 5,
                    Description = "Files",
                    Order = 5,
                });

            builder
                .HasData(new PropertyGroup
                {
                    Id = 6,
                    Description = "Categories",
                    Order = 6,
                }); 
            
            builder
                .HasData(new PropertyGroup
                {
                    Id = 7,
                    Description = "Related Products",
                    Order = 7,
                });
        }
    }
}
