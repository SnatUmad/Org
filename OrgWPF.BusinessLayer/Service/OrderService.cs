using AutoMapper;
using OrgWPF.DataLayer.Entities;
using OrgWPF.DataLayer.Interfaces;
using OrgWPF.DataLayer.Repository;
using OrgWPF.BusinessLayer.Interfaces;
using OrgWPF.BusinessLayer.Models;
using System.Collections.ObjectModel;

namespace OrgWPF.BusinessLayer.Service
{
    public class OrderService : IOrgService<OrderViewModel>
    {
        IUnitOfWork dataBase;
        public OrderService(string name)
        {
            dataBase = new EntityUnitOfWork(name);
        }
        public void Create(OrderViewModel t)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public OrderViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Order, OrderViewModel>();
                cfg.CreateMap<Payment, PaymentViewModel>();
            });
            var order = Mapper.Map<OrderViewModel>(dataBase.Orders.Get(id));
            return order;
        }

        public ObservableCollection<OrderViewModel> GetAll()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Client, ClientViewModel>();
                cfg.CreateMap<Order, OrderViewModel>();
                cfg.CreateMap<Payment, PaymentViewModel>();
            });
            var orders = Mapper.Map<ObservableCollection<OrderViewModel>>(dataBase.Orders.GetAll());
            return orders;
        }

        public void Update(OrderViewModel order)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<OrderViewModel, Order>();
                cfg.CreateMap<PaymentViewModel, Payment>();
            });
            var ord = Mapper.Map<Order>(order);
            dataBase.Orders.Update(ord);
            dataBase.Save();
        }

        public void AddOrderToClient(int clientID, OrderViewModel order)
        {
            var client = dataBase.Clients.Get(clientID);
            Mapper.Initialize(cfg => cfg.CreateMap<OrderViewModel, Order>());
            var ord = Mapper.Map<Order>(order);
            dataBase.Orders.Create(ord);
            dataBase.Save();
        }

        public void RemoveOrderFromClient(int clientID, OrderViewModel order)
        {
            var client = dataBase.Clients.Get(clientID);
            Mapper.Initialize(cfg => cfg.CreateMap<OrderViewModel, Order>());
            var ord = Mapper.Map<Order>(order);
            dataBase.Orders.Delete(ord.OrderID);
            dataBase.Save();
        }
    }
}
