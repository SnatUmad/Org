using AutoMapper;
using OrgWPF.DataLayer.Entities;
using OrgWPF.DataLayer.Interfaces;
using OrgWPF.DataLayer.Repository;
using OrgWPF.BusinessLayer.Interfaces;
using OrgWPF.BusinessLayer.Models;
using System.Collections.ObjectModel;

namespace OrgWPF.BusinessLayer.Service
{
    public class ClientService : IOrgService<ClientViewModel>
    {
        IUnitOfWork dataBase;
        public ClientService(string name)
        {
            dataBase = new EntityUnitOfWork(name);
        }

        public void Create(ClientViewModel t)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ClientViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Client, ClientViewModel>();
                cfg.CreateMap<Order, OrderViewModel>();
            });
            var client = Mapper.Map<ClientViewModel>(dataBase.Clients.Get(id));
            return client;
        }

        public ObservableCollection<ClientViewModel> GetAll()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Client, ClientViewModel>();
                cfg.CreateMap<Order, OrderViewModel>();
            });
            var cl = dataBase.Clients.GetAll();
            var clients = Mapper.Map<ObservableCollection<ClientViewModel>>(cl);
            return clients;
        }

        public void Update(ClientViewModel client)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ClientViewModel, Client>();
            });
            var clin = Mapper.Map<Client>(client);
            dataBase.Clients.Update(clin);
            dataBase.Save();
        }
        public void AddClientToOrg(int orgID, ClientViewModel client)
        {
            var org = dataBase.Orgs.Get(orgID);
            Mapper.Initialize(cfg => cfg.CreateMap<ClientViewModel, Client>());
            var clin = Mapper.Map<Client>(client);
            dataBase.Clients.Create(clin);
            dataBase.Save();
        }
        public void RemoveClientFromOrg(int orgID, ClientViewModel client)
        {
            var org = dataBase.Orgs.Get(orgID);
            Mapper.Initialize(cfg => cfg.CreateMap<ClientViewModel, Client>());
            var clin = Mapper.Map<Client>(client);
            dataBase.Clients.Delete(clin.ClientID);
            dataBase.Save();
        }
    }
}
