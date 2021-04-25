using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class DailyCost
    {
        public int DailyCostId { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
