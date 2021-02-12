using System;
using System.Collections.Generic;
using System.Text;

namespace AlugaJogos.Model
{
    public class Propertie
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public PropertieType PropertieType { get; set; }
        public int Order { get; set; }
        public PropertieGroup Group { get; set; }
        public bool Displayable { get; set; }
        public bool Searchable { get; set; }
        public bool Filterable { get; set; }
        public string DefaultValue { get; set; }
        public IList<PropertieDefaultOptions> DefaultOptions { get; set; }
    }
}
