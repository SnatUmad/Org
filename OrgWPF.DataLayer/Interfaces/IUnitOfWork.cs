using System;
using OrgWPF.DataLayer.Entities;


namespace OrgWPF.DataLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable    
    {
        IRepository<Client> Clients { get; }
        IRepository<Order> Orders { get; }
        IRepository<Org> Orgs { get; }
        IRepository<Payment> Payments { get; }
        void Save();
    }
}
