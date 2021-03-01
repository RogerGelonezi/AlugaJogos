using System.Collections.Generic;

namespace AlugaJogos.Model
{
    public class Property : IClass
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public PropertyType PropertyType { get; set; }
        public int Order { get; set; }
        public PropertyGroup Group { get; set; }
        public bool Mandadory { get; set; }
        public bool Displayable { get; set; }
        public bool Searchable { get; set; }
        public bool Filterable { get; set; }
        public string DefaultValue { get; set; }
        public IList<PropertyDefaultOption> DefaultOptions { get; set; }
        public bool CriticalProperty { get; set; }
    }
}
