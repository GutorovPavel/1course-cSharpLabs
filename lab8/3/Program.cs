using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        /*private static void DisplayNotification(string notification)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(notification);
            Console.ResetColor();
        }*/
        static void Main(string[] args)
        {
            Human bob = new Specialist(sexEnum.Male, -18, "bob", "Marley", 1000, "BSUIR", "CSPT");

            bob.Information();
            Console.WriteLine("-----------------------------\nBob's account history:\n");
            //anonymous method
            bob.Notify += delegate (string notification)
            {
                Console.WriteLine(notification);
            };
            bob.BalanceReplenishment(500);
            bob.Purchase(1200);

            Human lana = new Student(sexEnum.Female, 24, "Lana", "Rhoades", 200, "BSU");

            lana.Information();
            Console.WriteLine("-----------------------------\nLana's account history:\n");
            //lambda method
            lana.Notify += notification => Console.WriteLine(notification);
            lana.Purchase(300);

            Human lana2 = lana;

            Console.ReadKey();
        }
    }
}

