using System;
using OrgWPF.DataLayer.Interfaces;
using OrgWPF.DataLayer.EFContext;
using OrgWPF.DataLayer.Entities;

namespace OrgWPF.DataLayer.Repository
{
    public class EntityUnitOfWork : IUnitOfWork
    {
        OrgContext context;
        ClientRepository clientRepository;
        OrderRepository orderRepository;
        OrgRepository orgRepository;
        PaymentRepository paymentRepository;
        public EntityUnitOfWork(string name)
        {
            context = new OrgContext(name);
        }
        public IRepository<Client> Clients
        {
            get
            {
                if (clientRepository == null)
                {
                    clientRepository = new ClientRepository(context);
                }
                return clientRepository;
            }
        }
        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository(context);
                }
                return orderRepository;
            }
        }
        public IRepository<Org> Orgs
        {
            get
            {
                if (orgRepository == null)
                {
                    orgRepository = new OrgRepository(context);
                }
                return orgRepository;
            }
        }
        public IRepository<Payment> Payments
        {
            get
            {
                if (paymentRepository == null)
                {
                    paymentRepository = new PaymentRepository(context);
                }
                return paymentRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
