using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Specialist : Student
    {
        public Specialist(sexEnum sex, int age, string name, string secondName, int sum, string university, string speciality) :
            base(sex, age, name, secondName, sum, university)
        {
            Speciality = speciality;
        }
        private string speciality;
        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }
        public override void Information()
        {
            base.Information();
            if (University != null)
            {
                if (Sex == sexEnum.Male || Sex == sexEnum.Undefined)
                {
                    Console.WriteLine($"He is studying for an {Speciality}!");
                }
                else
                {
                    Console.WriteLine($"She is studying for an {Speciality}!");
                }
            }
        }
    }
}
