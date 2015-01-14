using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kl1nt.CodeKata.SupermarketPricing.Models
{
    public class Product
    {
        public virtual string Name { get; set; }
        public virtual ProductUnit Unit { get; set; }
    }
}
