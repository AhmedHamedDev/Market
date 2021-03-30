using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class GeneralProductType
    {
        public int GeneralProductTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<ProductType> ProductTypes { get; set; }
    }
}
