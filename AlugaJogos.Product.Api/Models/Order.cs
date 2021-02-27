using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlugaJogos.Product.Api.Models
{
    public class Order
    {
        public string OrderPrimaryPriority { get; set; }
        public string OrderSecondaryPriority { get; set; }
        public string OrderThirdyPriority { get; set; }
    }
}
