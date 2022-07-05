using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatern.Classes
{
    public class BankA : IBank
    {
        public string Withdraw()
        {
            return "Your Request is handling with BankA";
        }
    }
}
