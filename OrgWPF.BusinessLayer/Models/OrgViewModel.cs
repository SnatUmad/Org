using System.Collections.ObjectModel;

namespace OrgWPF.BusinessLayer.Models
{
    public class OrgViewModel
    {
        public int OrgID { get; set; }
        public string OrgYNP { get; set; }
        public string OrgName { get; set; }
        public string OrgManager { get; set; }
        public string OrgAdress { get; set; }
        public int OrgPhone { get; set; }
        public int OrgFax { get; set; }
        public string OrgR_S { get; set; }
        public ObservableCollection<ClientViewModel> Clients { get; set; }
    }
}
