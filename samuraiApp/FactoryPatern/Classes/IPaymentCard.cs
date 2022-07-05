using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatern.Classes
{
    public interface IPaymentCard
    {
        string GetName();
        string GetProvierInfo();
    }
    public class VisaCard : IPaymentCard
    {
        public string GetName()
        {
            return "Visa Card";
        }

        public string GetProvierInfo()
        {
            return "Visa !";

        }
    }
    public class MasterCard : IPaymentCard
    {
        public string GetName()
        {
            return "Master Card";
        }

        public string GetProvierInfo()
        {
            return "Master !";

        }
    }
}
