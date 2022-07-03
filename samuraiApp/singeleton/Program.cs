using System;

namespace singeleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            counter counter1 = counter.getInstance();
            counter counter2 = counter.getInstance();
            counter1.AddOne();
            counter2.AddOne();
            counter1.AddOne();

            Console.WriteLine("counter1:" + counter1.count);
            Console.WriteLine("counter2:" + counter2.count);
        }
    }
}