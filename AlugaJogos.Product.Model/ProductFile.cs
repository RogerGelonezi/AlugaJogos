using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaJogos.Model
{
    public class ProductFile
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
