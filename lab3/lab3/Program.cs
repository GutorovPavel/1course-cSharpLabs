using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] wordArray = str.Split(' ');
            int count = wordArray.Length;
            Console.WriteLine();
            for (int i = count - 1; i >= 0; i--)
                Console.Write(wordArray[i] + " ");

            Console.ReadKey();
        }
    }
}
