using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime InsertTime { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}
