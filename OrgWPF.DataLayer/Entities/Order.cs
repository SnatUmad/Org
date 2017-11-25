using System;
using System.Collections.Generic;

namespace OrgWPF.DataLayer.Entities
{
    public class Order
    {
        public int OrderID { get; set; }        
        public int ClientID { get; set; }
        public string OrderWaybill { get; set; }
        public string OrderDataPayment { get; set; }
        public int OrderSumm { get; set; }
        public string OrderCondition { get; set; }
        public string OrderDataShipment { get; set; }
        public string OrderNote { get; set; }
        public List<Payment> Payments { get; set; }
        public Order()
        {
            Payments = new List<Payment>();
        }
        //navigation
        public Client Client { get; set; }        
    }
}
