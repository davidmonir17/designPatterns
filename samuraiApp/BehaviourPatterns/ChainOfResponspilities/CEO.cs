using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.ChainOfResponspilities
{
    public class CEO:Handler
    {
        public override Request handlerRequest(Request request)
        {
           
                    request.res = $"CEO: I'll approve the {request.ToString()}.\n";
                    return request;
              
           


        }
    }
}
