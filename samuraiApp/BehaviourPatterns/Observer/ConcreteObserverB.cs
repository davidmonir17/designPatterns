using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.Observer
{
    public class ConcreteObserverB:IObserver
    {
        public void Update(Isubject subject)
        {
            if ((subject as Subject).state == 0 || (subject as Subject).state >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
