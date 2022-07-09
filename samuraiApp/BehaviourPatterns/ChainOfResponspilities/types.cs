using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.ChainOfResponspilities
{
    public enum  Requesttype
    {
        Confirace,purcase
    }
    public class Request
    {
        public Requesttype type;
        public double Amount;
        public string res;

        

        public Request(Requesttype type,double amount)
        {
            this.type = type;
            Amount = amount;
        }
    }
}
