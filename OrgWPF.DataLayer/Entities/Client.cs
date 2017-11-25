using System.Collections.Generic;

namespace OrgWPF.DataLayer.Entities
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientManager { get; set; }
        public int ClientPhone { get; set; } 
        public int OrgID { get; set; }
        //navigation             
        public virtual List<Order> Orders { get; set; }
        public Client()
        {
            Orders = new List<Order>();
        }
        public Org Org { get; set; }
    }
}
