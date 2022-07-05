using System;
using System.Threading.Tasks;

namespace singeleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task task1 = Task.Factory.StartNew(() =>
            {
            counter counter1 = counter.getInstance();
            counter1.AddOne();

            Console.WriteLine("counter1:" + counter1.count.ToString());
            });
            Task task2 = Task.Factory.StartNew(() =>
            {

                counter counter2 = counter.getInstance();
                counter2.AddOne();
            Console.WriteLine("counter2:" + counter2.count.ToString());
            });
//            counter1.AddOne();
            Console.ReadKey();

        }
    }
}