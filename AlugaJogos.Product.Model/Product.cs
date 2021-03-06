﻿using System.Collections.Generic;

namespace AlugaJogos.Model
{
    public class Product
    {
        public int Id { get; set; }
        public IList<ProductProperty> Properties { get; set; }
        public IList<ProductImage> Images { get; set; }
        public IList<ProductVideo> Videos { get; set; }
        public IList<ProductFile> Files { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<Product> RelatedProducts { get; set; }
    }
}
