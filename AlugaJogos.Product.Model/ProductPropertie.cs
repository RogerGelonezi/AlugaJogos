using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaJogos.Model
{
    public class ProductPropertie
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Propertie Propertie { get; set; }
        public string Value { get; set; }
    }
}
