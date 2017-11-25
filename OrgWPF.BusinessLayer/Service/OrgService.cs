using AutoMapper;
using OrgWPF.DataLayer.Entities;
using OrgWPF.DataLayer.Interfaces;
using OrgWPF.DataLayer.Repository;
using OrgWPF.BusinessLayer.Interfaces;
using OrgWPF.BusinessLayer.Models;
using System.Collections.ObjectModel;

namespace OrgWPF.BusinessLayer.Service
{
    public class OrgService : IOrgService<OrgViewModel>    
    {
        IUnitOfWork dataBase;
        public OrgService(string name)
        {
            dataBase = new EntityUnitOfWork(name);
        }

        public ObservableCollection<OrgViewModel> GetAll()
        {
            Mapper.Initialize(cfg =>
            {                
                cfg.CreateMap<Org, OrgViewModel>();
                cfg.CreateMap<Client, ClientViewModel>();
                cfg.CreateMap<Order, OrderViewModel>();
            });
            var or = dataBase.Orgs.GetAll();
            var orgs = Mapper.Map<ObservableCollection<OrgViewModel>>(or);
            return orgs;            
        }

        public OrgViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Org, OrgViewModel>();
                cfg.CreateMap<Client, ClientViewModel>();
                cfg.CreateMap<Order, OrderViewModel>();
            });
            var org = Mapper.Map<OrgViewModel>(dataBase.Orgs.Get(id));
            return org;
        }

        public void Create(OrgViewModel org)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<OrgViewModel, Org>();               
            });
            var organiz = Mapper.Map<Org>(org);            
            dataBase.Orgs.Create(organiz);
            dataBase.Save();
        }

        public void Update(OrgViewModel org)
        {
            //var or = dataBase.Orgs.Get(org.OrgID);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<OrgViewModel, Org>();
                cfg.CreateMap<ClientViewModel, Client>();
            });
            var organiz = Mapper.Map<Org>(org);            
            dataBase.Orgs.Update(organiz);
            dataBase.Save();
        }

        public void Delete(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Org, OrgViewModel>();                
            });            
            dataBase.Orgs.Delete(id);
            dataBase.Save();
        }       
    }
}
