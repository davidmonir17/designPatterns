using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Decorator
{
    public class NotifictionEmailDecorator:AbstractDecorator
    {
        public string SMSSendNotification(string cusid,string sms)
        {
            return $"sms:{sms} , sent to {cusid}";
        }
        public override string SendSMS(string cusId, string mobile, string sms)
        {StringBuilder result=new StringBuilder();
            result.AppendLine(base.SendSMS(cusId, mobile, sms));
            result.AppendLine(SMSSendNotification(cusId, sms));
            return result.ToString();
        }
    }
}
