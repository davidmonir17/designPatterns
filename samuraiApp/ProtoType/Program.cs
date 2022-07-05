using ProtoType.classes;
using System;

namespace ProtoType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeProtoType temp1 = new TempEmployee();
            temp1.Name = "teemp1 dsd";
            temp1.Id = 1;
            temp1.EmpAddress = new Address { Bulding = "B1", StreetName = "Street 1", City = "City 1" };

            EmployeeProtoType temp2=temp1.ShallowCopy();

            Console.WriteLine("=========Temp original Value===========");
            Console.WriteLine(temp1.ToString());
            Console.WriteLine("=========Temp Copy Value===========");
            Console.WriteLine(temp2.ToString());

            temp2.EmpAddress.City = "New City";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========Temp original Value===========");
            Console.WriteLine(temp1.ToString());
            Console.WriteLine("=========Temp Copy Value===========");
            Console.WriteLine(temp2.ToString());

            Console.WriteLine("Hello World!");
        }
    }
}
