using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Student : Human, ICloneable
    {
        public Student(sexEnum sex, int age, string name, string secondName, int sum, string university) :
            base(sex, age, name, secondName, sum)
        {
            University = university;
        }
        private string university;
        public string University
        {
            get { return university; }
            set { university = value; }
        }
        public object Clone()
        {
            return new Student
            (
                this.Sex,
                this.Age,
                this.Name,
                this.SecondName,
                this.Sum,
                this.University
            );
        }
        public override void Information()
        {
            base.Information();
            if (University == null)
            {
                Console.WriteLine("He is not a student(\n");
            }
            else
            {
                if (Sex == sexEnum.Male || Sex == sexEnum.Undefined)
                {
                    Console.WriteLine($"He is a student of {University}");
                }
                else
                {
                    Console.WriteLine($"She is a student of {University}");
                }
            }
        }
    }
}
