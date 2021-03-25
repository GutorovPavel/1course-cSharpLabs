using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            Random r = new Random();
            int size = r.Next(1, 4);
            StringBuilder str = new StringBuilder(size);
            int numberOfLetter;
            for (int i = 0; i < size; i++)
            {
                numberOfLetter = r.Next(0, letters.Length - 1);
                str.Append(letters[numberOfLetter]);
                Console.Write(str[i]);
            }
            Console.ReadKey();
        }
    }
}
