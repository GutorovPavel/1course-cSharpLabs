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
            Specialist bob = new Specialist();

            bob.sex = Sex.Male;
            bob.Age = 18;
            bob.Name = "Bob";
            bob.SecondName = "Marley";
            bob.University = "BSUIR";
            bob.Сourse = 1;
            bob.Speciality = "CSPT";

            Student lana = new Student();

            lana.sex = Sex.Female;
            lana.Age = 24;
            lana.Name = "Lana";
            lana.SecondName = "Rhoades";
            lana.University = "BSU";

            Specialist drake = new Specialist();

            drake.sex = Sex.Male;
            drake.Age = 25;
            drake.Name = "Aubrey";
            drake.SecondName = "Graham";

            bob[0] = lana; 
            bob[0] = drake;

            bob.Information();
            lana.Information();
            Console.WriteLine();
            drake.Information();

            Console.ReadKey();
        }
    }
}

