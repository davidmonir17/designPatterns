using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.ChainOfResponspilities
{
    public class Director : Handler
    {
        public override Request handlerRequest(Request request)
        {
            if(request.type==Requesttype.Confirace)
            {
                request.res= $"Director: I'll approve the {request.ToString()}.\n";
                return request;
            }
            else
            {
                return base.handlerRequest(request);
            }

        }
    }
}
