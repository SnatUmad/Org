using System.Collections.Generic;

namespace OrgWPF.DataLayer.Entities
{
    public class Org
    {
        public int OrgID { get; set; }
        public string OrgYNP { get; set; }
        public string OrgName { get; set; }
        public string OrgManager { get; set; }
        public string OrgAdress { get; set; }
        public int OrgPhone { get; set; }
        public int OrgFax { get; set; }
        public string OrgR_S { get; set; }
        //navigation        
        public List<Client> Clients { get; set; }
        public Org()
        {
            Clients = new List<Client>();
        }
    }
}
