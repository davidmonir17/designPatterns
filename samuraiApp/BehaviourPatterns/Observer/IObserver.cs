using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.Observer
{
    public interface IObserver
    {
        void Update(Isubject subject);
    }
}
