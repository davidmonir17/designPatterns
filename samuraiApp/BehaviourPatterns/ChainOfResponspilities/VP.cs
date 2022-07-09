using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.ChainOfResponspilities
{
    public class VP:Handler
    {
        public override Request handlerRequest(Request request)
        {
            if (request.type == Requesttype.purcase)
            {
                if (request.Amount <= 1500) { 
                request.res = $"Vp: I'll approve the {request.ToString()}.\n";
                return request;
                }
                else
                {
                    return base.handlerRequest(request);
                }
            }
            return null;
           

        }
    }
}
