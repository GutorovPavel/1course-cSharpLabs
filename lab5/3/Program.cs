using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Specialist(Sex.Male, 18, "bob", "Marley", "BSUIR", "CSPT");

            //bob.sex = Sex.Male;
            //bob.Age = 18;
            //bob.Name = "Bob";
            //bob.SecondName = "Marley";
            //bob.University = "BSUIR";
            //bob.Сourse = 1;
            //bob.Speciality = "CSPT";

            Human lana = new Student(Sex.Female, 24, "Lana", "Rhoades", "BSU");

            //lana.sex = Sex.Female;
            //lana.Age = 24;
            //lana.Name = "Lana";
            //lana.SecondName = "Rhoades";
            //lana.University = "BSU";

            bob.Information();
            lana.Information();

            Console.ReadKey();
        }
    }
}

