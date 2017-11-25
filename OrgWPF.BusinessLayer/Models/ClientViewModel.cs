using System.Collections.ObjectModel;

namespace OrgWPF.BusinessLayer.Models
{
    public class ClientViewModel
    {
        public int ClientID { get; set; }
        public string ClientManager { get; set; }
        public int ClientPhone { get; set; }
        public int OrgID { get; set; }
        public ObservableCollection<OrderViewModel> Orders { get; set; }
    }
}
