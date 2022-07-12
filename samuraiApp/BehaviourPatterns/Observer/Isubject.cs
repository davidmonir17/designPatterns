using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.Observer
{
    public interface Isubject
    {
        void attach(IObserver observer);
        void detach(IObserver observer);
        void Notify();
    }
}
