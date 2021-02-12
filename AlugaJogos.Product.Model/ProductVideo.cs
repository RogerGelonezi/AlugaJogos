using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaJogos.Model
{
    public class ProductVideo
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string EmbeddedCode { get; set; }
    }
}
