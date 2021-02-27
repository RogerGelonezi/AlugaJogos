using AlugaJogos.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlugaJogos.Persistence
{
    internal class PropertieGroupConfiguration : IEntityTypeConfiguration<PropertieGroup>
    {
        public void Configure(EntityTypeBuilder<PropertieGroup> builder)
        {
            builder
                .HasIndex(p => p.Description)
                .IsUnique();

            builder
                .HasData(new PropertieGroup
                {
                    Id= 1,
                    Description = "Main",
                    Order = 1,
                });

            builder
                .HasData(new PropertieGroup
                {
                    Id = 2,
                    Description = "Properties",
                    Order = 2,
                });

            builder
                .HasData(new PropertieGroup
                {
                    Id = 3,
                    Description = "Images",
                    Order = 3,
                });

            builder
                .HasData(new PropertieGroup
                {
                    Id = 4,
                    Description = "Videos",
                    Order = 4,
                });

            builder
                .HasData(new PropertieGroup
                {
                    Id = 5,
                    Description = "Files",
                    Order = 5,
                });

            builder
                .HasData(new PropertieGroup
                {
                    Id = 6,
                    Description = "Categories",
                    Order = 6,
                }); 
            
            builder
                .HasData(new PropertieGroup
                {
                    Id = 7,
                    Description = "Related Products",
                    Order = 7,
                });
        }
    }
}
