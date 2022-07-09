using BehaviourPatterns.ChainOfResponspilities;
using System;

namespace BehaviourPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handler brayn =new Director();
            Handler Crystal =new VP();
            Handler jeff =new CEO();
            brayn.setSuccessor(Crystal);
            Crystal.setSuccessor(jeff);
            var requst = new Request(Requesttype.Confirace, 500);
            brayn.handlerRequest(requst);
            Console.WriteLine(requst.res.ToString());

            requst = new Request(Requesttype.purcase, 1000);
            brayn.handlerRequest(requst);

            Console.WriteLine(requst.res.ToString());

             requst = new Request(Requesttype.purcase, 1700);
            brayn.handlerRequest(requst);

            Console.WriteLine(requst.res.ToString());
        }
    }
}
