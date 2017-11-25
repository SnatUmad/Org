using System;
using System.Collections.Generic;
using System.Linq;
using OrgWPF.DataLayer.Interfaces;
using OrgWPF.DataLayer.Entities;
using OrgWPF.DataLayer.EFContext;
using System.Data.Entity;

namespace OrgWPF.DataLayer.Repository
{
    public class OrgRepository : IRepository<Org>    
    {
        OrgContext context;
        public OrgRepository(OrgContext context)
        {
            this.context = context;
        }
        public void Create(Org t)
        {
            context.Orgs.Add(t);
        }
        public void Update(Org t)
        {            
            context.Entry<Org>(t).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var org = context.Orgs.Find(id);
            context.Orgs.Remove(org);            
        }
        public IEnumerable<Org> Find(Func<Org, bool> predicate)
        {
            return context.Orgs.Include(g =>g.Clients).Where(predicate).ToList();
        }
        public Org Get(int id)
        {
            return context.Orgs.Find(id);
        }
        public IEnumerable<Org> GetAll()
        {
            return context.Orgs.Include(g =>g.Clients).ToList();
        }
    }
}
