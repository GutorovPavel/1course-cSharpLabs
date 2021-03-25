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
            Console.CursorVisible = false;
            string letters = "abcdefghijklmnopqrstuvwxyz";
            int numberOfLetter;
            Random r = new Random();
            while (true)
            {
                int size = r.Next(1, 5);
                StringBuilder str = new StringBuilder(size);
                for (int i = 0; i < size; i++)
                {
                    numberOfLetter = r.Next(0, letters.Length - 1);
                    str.Append(letters[numberOfLetter]);
                }
                Console.WriteLine(str.ToString() + "\n\nEnter q to exit.");
                Console.ForegroundColor = ConsoleColor.Black;
                char key = Console.ReadKey().KeyChar;
                if (key == 'q' || key == 'Q')
                    return;
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                }
            }
        }
    }
}
