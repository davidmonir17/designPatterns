using BehaviourPatterns.ChainOfResponspilities;
using BehaviourPatterns.Observer;
using BehaviourPatterns.State;
using System;

namespace BehaviourPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ChainOfResponsiblites
            //    Handler brayn =new Director();
            //    Handler Crystal =new VP();
            //    Handler jeff =new CEO();
            //    brayn.setSuccessor(Crystal);
            //    Crystal.setSuccessor(jeff);
            //    var requst = new Request(Requesttype.Confirace, 500);
            //    brayn.handlerRequest(requst);
            //    Console.WriteLine(requst.res.ToString());

            //    requst = new Request(Requesttype.purcase, 1000);
            //    brayn.handlerRequest(requst);

            //    Console.WriteLine(requst.res.ToString());

            //     requst = new Request(Requesttype.purcase, 1700);
            //    brayn.handlerRequest(requst);

            //    Console.WriteLine(requst.res.ToString());
            #endregion


            #region Observer
            //var subject = new Subject();
            //var observerA = new ConcreteObserverA();
            //subject.attach(observerA);

            //var observerB = new ConcreteObserverB();
            //subject.attach(observerB);

            //subject.SomeBusinessLogic();
            //subject.SomeBusinessLogic();

            //subject.detach(observerB);

            //subject.SomeBusinessLogic();

            #endregion

            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}
