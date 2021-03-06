﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace AlugaJogos.Product.Api.Filters
{
    public class TagDescriptionsDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Tags = new List<OpenApiTag> {
                new OpenApiTag { Name = "PropertyGroups", Description = "Organizes properties in group tabs." },
                new OpenApiTag { Name = "Properties", Description = "Defines the possible characteristics of the products." }
            };
        }
    }
}
