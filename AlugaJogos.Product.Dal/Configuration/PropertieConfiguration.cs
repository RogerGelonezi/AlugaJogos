﻿using AlugaJogos.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlugaJogos.Persistence
{
    public class PropertieConfiguration : IEntityTypeConfiguration<Propertie>
    {
        public void Configure(EntityTypeBuilder<Propertie> builder)
        {
            //builder.HasData(new Propertie
            //{
            //    Description = "Name",
            //    PropertieType = PropertieType.String,
            //    Order = 1,
            //    ...
            //});
        }
    }
}