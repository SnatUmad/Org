using System;
using System.Collections.Generic;
using System.Data.Entity;
using OrgWPF.DataLayer.Entities;

namespace OrgWPF.DataLayer.EFContext
{
    public class OrgInitializer : DropCreateDatabaseAlways<OrgContext>
    {
        protected override void Seed(OrgContext context)
        {
            context.Orgs.AddRange(new Org[]
            {
                new Org
                {
                    OrgID=1,
                    OrgYNP ="100100300",
                    OrgAdress ="г.Миник, пр-кт Машерова 89, ком 1089",
                    OrgFax=2894067,
                    OrgPhone =895689,
                    OrgManager ="Брошин И.И.",
                    OrgName ="CD_Life",
                    OrgR_S ="0000000000000",
                    Clients =new List<Client>
                    {
                        new Client
                        {
                            ClientID=1,
                            ClientManager="Скорый И.С.",
                            ClientPhone=2223017,
                            OrgID=1,
                            Orders=new List<Order>
                            {
                                new Order
                                {
                                    OrderID=1,
                                    ClientID=1,
                                    OrderWaybill="NA121",
                                    OrderDataPayment="01.01.2017",
                                    OrderSumm=20000,
                                    OrderCondition="3",
                                    OrderDataShipment="01.02.2017",
                                    OrderNote="-",
                                    Payments=new List<Payment>
                                    {
                                        new Payment
                                        {
                                            PaymentID=1,
                                            OrderID=1,
                                            PaymentData="05.01.2017",
                                            PaymentNumber=20,
                                            PaymentSumm=10000,
                                            PaymentBank_Code=1,
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            });
            context.SaveChanges();
        }
    }   
}
