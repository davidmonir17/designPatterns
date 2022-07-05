using FactoryPatern.Classes;
using System;

namespace FactoryPatern
{
    internal class Program
    {
        static void Main(string[] args)
        {   IBankFactory bankFactory = new BankFactory();
            string CardNum, bankCode;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Enter Your CardNumber");
            CardNum=Console.ReadLine();
            bankCode = CardNum.Substring(0, 6);
            IBank bank = bankFactory.GetBank(bankCode);
            Console.WriteLine(bank.Withdraw());


        }
    }
}
