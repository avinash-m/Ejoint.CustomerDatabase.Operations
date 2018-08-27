using System;

namespace Ejoint.CustomerDatabase.Model
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
