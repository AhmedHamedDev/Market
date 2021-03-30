using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public DateTime InsertTime { get; set; }


        public int VillageId { get; set; }
        public Village Village { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
