using System;
using System.Collections.Generic;
using System.Linq;
using OrgWPF.DataLayer.EFContext;
using OrgWPF.DataLayer.Entities;
using OrgWPF.DataLayer.Interfaces;
using System.Data.Entity;

namespace OrgWPF.DataLayer.Repository
{
    public class ClientRepository : IRepository<Client>
    {
        OrgContext context;
        public ClientRepository(OrgContext context)
        {
            this.context = context;
        }
        public void Create(Client t)
        {
            context.Clients.Add(t);
        }
        public void Delete(int id)
        {
            var client = context.Clients.Find(id);
            context.Clients.Remove(client);            
        }
        public IEnumerable<Client> Find(Func<Client, bool> predicate)
        {
            return context.Clients.Include(g => g.Orders).Where(predicate).ToList();
        }
        public Client Get(int id)
        {
            return context.Clients.Find(id);
        }
        public IEnumerable<Client> GetAll()
        {
            return context.Clients.Include(g => g.Orders).ToList();
        }
        public void Update(Client t)
        {
            context.Entry<Client>(t).State = EntityState.Modified;
        }
    }    
}
