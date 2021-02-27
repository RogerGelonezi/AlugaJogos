using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlugaJogos.Model
{
    public class PropertieGroup : IClass
    {
        public int Id { get; set; }
        
        [Required]
        public string Description { get; set; }
        public int Order { get; set; }
        // public IList<Propertie> Properties { get; set; }
    }
}
