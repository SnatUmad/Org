using System;

namespace OrgWPF.BusinessLayer.Models
{
    public class PaymentViewModel
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public string PaymentData { get; set; }
        public int PaymentNumber { get; set; }
        public int PaymentSumm { get; set; }
        public int PaymentBank_Code { get; set; }
    }
}
