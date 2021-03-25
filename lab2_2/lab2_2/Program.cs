using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime MyMonth;
            Console.WriteLine("Choose the language: russian, french, english");
            string str = Console.ReadLine();
            while (true)
            {
                if (str == "russian" || str == "Russian" || str == "RUSSIAN")
                {
                    for (int i = 10; i < 22; i++)  //в цикле будет использован метод AddMonths, отсчет начнется с марта, март+10 = январь
                    {
                        MyMonth = DateTime.Now.AddMonths(i);
                        Console.WriteLine(MyMonth.ToString("MMMM", CultureInfo.GetCultureInfo("ru-RU"))); //методом GetCultureInfo выводим месяца на русский язык
                    }
                    break;
                }
                else if (str == "french" || str == "French" || str == "FRENCH")
                {
                    for (int i = 10; i < 22; i++)
                    {
                        MyMonth = DateTime.Now.AddMonths(i);
                        Console.WriteLine(MyMonth.ToString("MMMM", CultureInfo.GetCultureInfo("fr")));
                    }
                    break;
                }
                else if (str == "english" || str == "English" || str == "ENGLISH")
                {
                    for (int i = 10; i < 22; i++)
                    {
                        MyMonth = DateTime.Now.AddMonths(i);
                        Console.WriteLine(MyMonth.ToString("MMMM", CultureInfo.GetCultureInfo("en-US")));
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again: ");
                    str = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
