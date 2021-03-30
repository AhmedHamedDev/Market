using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Village
    {
        public int VillageId { get; set; }
        public string VillageName { get; set; }
        public decimal DeliveryCost { get; set; }
        public DateTime InsertTime { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
