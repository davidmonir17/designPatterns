using Proxy.Adapter;
using Proxy.Classes;
using Proxy.Decorator;
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

            Eployee eployee = new Eployee();
            eployee.name = "david";
            eployee.BasicSalary = 2000;
            MachineOperator machine = new MachineOperator();
            machine.BasicSalary = 3000;
            SalaryAdapter salaryCalcolator = new SalaryAdapter();
            double sal=salaryCalcolator.CalcSalary(machine);
            Console.WriteLine(sal.ToString());


        }
    }
}
