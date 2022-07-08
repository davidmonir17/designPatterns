using Proxy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Decorator
{
    public abstract class AbstractDecorator:SMSServices
    {
        protected SMSServices notifServices;
        public void SetServices(SMSServices services)
        {
            notifServices = services;
        }
        public override string SendSMS(string cusId, string mobile, string sms)
        {
            if (notifServices != null)
            {
                return notifServices.SendSMS(cusId, mobile, sms);
            }
            else
            {
                return "Notification services Not Intialze!";
            }
        }
    }
}
