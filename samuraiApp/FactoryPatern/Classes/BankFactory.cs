using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatern.Classes
{
    public class BankFactory : IBankFactory
    {
        public IBank GetBank(string BanckCode)
        {
            switch (BanckCode)
            {
                case"123456":   return new BankA();   
                case "222222":  return new BankB();

            }
            return null;
        }

        public IPaymentCard GetCard(string CardNum)
        {

            switch (CardNum)
            {
                case "12": return new VisaCard();
                case "22": return new MasterCard();

            }
            return null;
        }
    }
}
