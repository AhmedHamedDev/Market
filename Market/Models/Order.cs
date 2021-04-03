using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public decimal TotalSell { get; set; }
        public bool IsDelivery { get; set; }
        public decimal DeliveryCost { get; set; }
        public decimal Discound { get; set; }
        public bool Delayed { get; set; }
        public DateTime InsertTime { get; set; }

        public int? ClientId { get; set; }
        public Client Client { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

    }
}
