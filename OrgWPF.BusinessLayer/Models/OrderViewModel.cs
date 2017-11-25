using System;
using System.Collections.ObjectModel;

namespace OrgWPF.BusinessLayer.Models
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }        
        public int ClientID { get; set; }
        public string OrderWaybill { get; set; }
        public string OrderData_Payment { get; set; }
        public int OrderSumm { get; set; }
        public string OrderCondition { get; set; }
        public string OrderData_Shipment { get; set; }
        public string OrderNote { get; set; }
        public ObservableCollection<PaymentViewModel> Payments { get; set; }
    }
}
