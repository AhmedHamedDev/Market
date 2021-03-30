using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime InsertTime { get; set; }

        public int GeneralProductTypeId { get; set; }
        public GeneralProductType GeneralProductTypes { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
