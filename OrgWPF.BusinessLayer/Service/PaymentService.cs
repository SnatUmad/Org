using AutoMapper;
using OrgWPF.DataLayer.Entities;
using OrgWPF.DataLayer.Interfaces;
using OrgWPF.DataLayer.Repository;
using OrgWPF.BusinessLayer.Interfaces;
using OrgWPF.BusinessLayer.Models;
using System.Collections.ObjectModel;

namespace OrgWPF.BusinessLayer.Service
{
    public class PaymentService : IOrgService<PaymentViewModel>
    {
        IUnitOfWork dataBase;
        public PaymentService(string name)
        {
            dataBase = new EntityUnitOfWork(name);
        }
        public void Create(PaymentViewModel t)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public PaymentViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Payment, PaymentViewModel>();
            });
            var payment = Mapper.Map<PaymentViewModel>(dataBase.Orders.Get(id));
            return payment;
        }

        public ObservableCollection<PaymentViewModel> GetAll()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Payment, PaymentViewModel>();
            });
            var payments = Mapper.Map<ObservableCollection<PaymentViewModel>>(dataBase.Payments.GetAll());
            return payments;
        }

        public void Update(PaymentViewModel payment)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<PaymentViewModel, Payment>();
            });
            var pmnt = Mapper.Map<Payment>(payment);
            dataBase.Payments.Update(pmnt);
            dataBase.Save();
        }

        public void AddPaymentToOrder(int orderID, PaymentViewModel payment)
        {
            var order = dataBase.Orders.Get(orderID);
            Mapper.Initialize(cfg => cfg.CreateMap<PaymentViewModel, Payment>());
            var pmnt = Mapper.Map<Payment>(payment);
            dataBase.Payments.Create(pmnt);
            dataBase.Save();
        }
        public void RemovePaymentFromOrder(int orderID, PaymentViewModel payment)
        {
            var order = dataBase.Orders.Get(orderID);
            Mapper.Initialize(cfg => cfg.CreateMap<PaymentViewModel, Payment>());
            var pmnt = Mapper.Map<Payment>(payment);
            dataBase.Payments.Delete(pmnt.PaymentID);
            dataBase.Save();
        }
    }
}
