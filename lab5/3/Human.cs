using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    enum Sex
    {
        Male,
        Female,
        Undefined
    }
    abstract class Human
    {
        public Sex sex { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name, secondName;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        private List<Human> groupmate = new List<Human>();
        public Human this[int index]
        {
            get { return groupmate[index]; }
            set { groupmate.Add(value); }
        }

        public virtual void Information()
        {
            Console.WriteLine($"Info about {Name} {SecondName}:");
            Console.WriteLine($"Age: {Age} \nSex: {sex}");
        }
    };
    class Student : Human
    {
        private string university;
        public string University
        {
            get { return university; }
            set { university = value; }
        }
        private int course;
        public int Сourse
        {
            get { return course; }
            set { course = value; }
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
                if (sex == Sex.Male || sex == Sex.Undefined)
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
    class Specialist : Student
    {
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
                if (sex == Sex.Male || sex == Sex.Undefined)
                {
                    Console.WriteLine($"He is studying for an {Speciality}!\n");
                }
                else
                {
                    Console.WriteLine($"She is studying for an {Speciality}!\n");
                }
            }
        }
    }
}
