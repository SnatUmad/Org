using System;

namespace OrgWPF.DataLayer.Entities
{
    public class Payment
    {
        public int PaymentID { get; set; } 
        public int OrderID { get; set; }
        public string PaymentData { get; set; }
        public int PaymentNumber { get; set; }
        public int PaymentSumm { get; set; }
        public int PaymentBank_Code { get; set; }        
        public Order Order { get; set; }        
    }
}
