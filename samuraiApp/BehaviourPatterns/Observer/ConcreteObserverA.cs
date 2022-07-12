using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.Observer
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(Isubject subject)
        {
            if((subject as Subject).state < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
