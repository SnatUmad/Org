using System;
using System.Collections.Generic;
using System.Linq;
using OrgWPF.DataLayer.Entities;
using OrgWPF.DataLayer.Interfaces;
using OrgWPF.DataLayer.EFContext;
using System.Data.Entity;

namespace OrgWPF.DataLayer.Repository
{
    public class OrderRepository : IRepository<Order>    
    {
        OrgContext context;
        public OrderRepository(OrgContext context)
        {
            this.context = context;
        }
        public void Create(Order t)
        {
            context.Orders.Add(t);
        }
        public void Update(Order t)
        {
            context.Entry<Order>(t).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var order = context.Orders.Find(id);
            context.Orders.Remove(order);            
        }
        public IEnumerable<Order> Find(Func<Order, bool> predicate)
        {
            return context.Orders.Include(g => g.Payments).Where(predicate).ToList();
        }
        public Order Get(int id)
        {
            return context.Orders.Find(id);
        }
        public IEnumerable<Order> GetAll()
        {
            return context.Orders.Include(g => g.Payments);
        }
    }
}
