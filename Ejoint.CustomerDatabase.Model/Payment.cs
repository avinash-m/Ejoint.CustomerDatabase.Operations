using System;

namespace Ejoint.CustomerDatabase.Model
{
    class Payment
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string PaymentType { get; set; }
        public double AmountPaid { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool IsSuccess { get; set; }
    }
}
