using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BehaviourPatterns.Observer
{
    public class Subject : Isubject
    {
        public int state { get; set; }=0;
        private List<IObserver>observers=new List<IObserver>();
        public void attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached observer!");
            this.observers.Add(observer);
        }

        public void detach(IObserver observer)
        {
            Console.WriteLine("Subject: Deattach observer!");
            this.observers.Remove(observer);
        }

        public void Notify()
        {

            Console.WriteLine("Subject: Notifying observers...");
            foreach (var obs in observers)
            {
                obs.Update(this);
            }
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.state = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.state);
            this.Notify();
        }
    }
}
