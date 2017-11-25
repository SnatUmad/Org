using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using OrgWPF.DataLayer.Interfaces;
using OrgWPF.DataLayer.EFContext;
using OrgWPF.DataLayer.Entities;

namespace OrgWPF.DataLayer.Repository
{
    public class PaymentRepository : IRepository<Payment>
    {
        OrgContext context;
        public PaymentRepository(OrgContext context)
        {
            this.context = context;
        }
        public void Create(Payment t)
        {
            context.Payments.Add(t);
        }
        public void Update(Payment t)
        {
            context.Entry<Payment>(t).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var payment = context.Payments.Find(id);
            context.Payments.Remove(payment);            
        }
        public IEnumerable<Payment> Find(Func<Payment, bool> predicate)
        {
            return context.Payments.Where(predicate).ToList();
        }
        public Payment Get(int id)
        {
            return context.Payments.Find(id);
        }
        public IEnumerable<Payment> GetAll()
        {
            return context.Payments;
        }
    }
}
