using Builder.classes;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Dierictor director = new Dierictor();
            IBulder carBulder = new Car("Jeep");
            IBulder MotoBulder = new MotorCycle("Honda");

            director.Construct(carBulder);
            Product car = carBulder.GetVehicle();
            Console.WriteLine("=========Car  Value===========");
            Console.WriteLine(car.show());

            Console.ForegroundColor = ConsoleColor.Red;
            director.Construct(MotoBulder);
            Product Moto = MotoBulder.GetVehicle();
            Console.WriteLine("=========MotoBulder Value===========");
            Console.WriteLine(Moto.show());

            
        }
    }
}
