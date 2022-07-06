using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public abstract class SMSServices
    {
        public abstract string SendSMS(string cusId, string mobile, string sms);
    }
}