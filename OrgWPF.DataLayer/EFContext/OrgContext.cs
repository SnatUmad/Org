using OrgWPF.DataLayer.Entities;
using System.Data.Entity;

namespace OrgWPF.DataLayer.EFContext
{
    public class OrgContext : DbContext    
    {
        public OrgContext(string name) : base(name)
        {
            Database.SetInitializer(new OrgInitializer());
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Org> Orgs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
