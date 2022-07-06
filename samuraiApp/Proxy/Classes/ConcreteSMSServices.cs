using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public class ConcreteSMSServices : SMSServices
    {
        public override string SendSMS(string cusId, string mobile, string sms)
        {
            return $"SMS sent to {mobile}";
        }
    }
}