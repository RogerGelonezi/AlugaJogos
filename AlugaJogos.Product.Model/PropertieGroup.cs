using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaJogos.Model
{
    public class PropertieGroup
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public IList<Propertie> Properties { get; set; }
    }
}
