using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.ChainOfResponspilities
{
    public abstract class Handler
    {
        public Handler sussesor = null;
        public Handler setSuccessor(Handler successor)
        {
            this.sussesor = successor;
            return successor;
        }
        public virtual Request handlerRequest(Request request)
        {
            if(sussesor != null)
            {
                return this.sussesor.handlerRequest(request);
            }else
            {
                return null;
            }
        }
    }
}
