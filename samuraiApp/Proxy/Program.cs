using Proxy.Adapter;
using Proxy.Classes;
using Proxy.Decorator;
using Proxy.Facade;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //SMSServicesProxy proxy =new SMSServicesProxy();
            //proxy.SendSMS("23", "01148010154", "first Mesg");
            // Console.WriteLine(proxy.SendSMS("23", "01148010154", "first Mesg"));
            // Console.WriteLine(proxy.SendSMS("23", "01148010154", "first Mesg"));
            #endregion
            #region 
            //ConcreteSMSServices concreteSMS=new ConcreteSMSServices();
            //NotifictionEmailDecorator emailDecorator=new NotifictionEmailDecorator();
            //emailDecorator.SetServices(concreteSMS);
            // Console.WriteLine(emailDecorator.SendSMS("23", "01148010154", "first Mesg"));
            // Console.WriteLine(emailDecorator.SendSMS("23", "01148010154", "first Mesg"));
            #endregion
            #region
            //Eployee eployee = new Eployee();
            //eployee.name = "david";
            //eployee.BasicSalary = 2000;
            //MachineOperator machine = new MachineOperator();
            //machine.BasicSalary = 3000;
            //SalaryAdapter salaryCalcolator = new SalaryAdapter();
            //double sal=salaryCalcolator.CalcSalary(machine);
            //Console.WriteLine(sal.ToString());
            #endregion

            ShoppingBasket basket  = new ShoppingBasket();
            basket.AddItem(new BasketItem
            {
                ItemId = 1,
                ItemPrice = 10,
                Quantity = 5
            });
            basket.AddItem(new BasketItem
            {
                ItemId = 2,
                ItemPrice = 10,
                Quantity = 5
            });
            basket.AddItem(new BasketItem
            {
                ItemId = 4,
                ItemPrice = 10,
                Quantity = 5
            }); basket.AddItem(new BasketItem
            {
                ItemId = 5,
                ItemPrice = 10,
                Quantity = 5
            }); 
            basket.AddItem(new BasketItem
            {
                ItemId = 6,
                ItemPrice = 10,
                Quantity = 5
            }); basket.AddItem(new BasketItem
            {
                ItemId = 7,
                ItemPrice = 10,
                Quantity = 5
            });
            basket.AddItem(new BasketItem
            {
                ItemId = 8,
                ItemPrice = 10,
                Quantity = 5
            }); basket.AddItem(new BasketItem
            {
                ItemId = 9,
                ItemPrice = 10,
                Quantity = 5
            });
            basket.AddItem(new BasketItem
            {
                ItemId = 10,
                ItemPrice = 20,
                Quantity = 5
            });

            PurshceOrder order =  new PurshceOrder();
            order.CreateOrder(basket, "david dsad ldkal;skd");
        }
    }
}
