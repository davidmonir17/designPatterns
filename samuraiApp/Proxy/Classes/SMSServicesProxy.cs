using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public class SMSServicesProxy : SMSServices
    {
        private SMSServices _smsServices;
        private Dictionary<string, int> LimitSMS = new Dictionary<string, int>();

        public override string SendSMS(string cusId, string mobile, string sms)
        {
            if (_smsServices == null) { _smsServices = new ConcreteSMSServices(); }
            //first one
            if (!LimitSMS.ContainsKey(cusId))
            {
                LimitSMS.Add(cusId, 1);
                return _smsServices.SendSMS(cusId, mobile, sms);
            }
            else
            {
                var cus = LimitSMS.Where(x => x.Key == cusId).FirstOrDefault();
                if (cus.Value >= 2) { return "Not Send !"; }
                else
                {
                    LimitSMS[cus.Key] = cus.Value + 1;
                    return _smsServices.SendSMS(cusId, mobile, sms);
                }
            }
        }
    }
}