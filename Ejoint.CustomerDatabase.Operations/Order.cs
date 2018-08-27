using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejoint.CustomerDatabase.Operations
{
    class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ItemName { get; set; }
        public bool IsElectronic { get; set; }
        public bool IsBook { get; set; }
        public bool IsMobile { get; set; }
    }
}
