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
        public Human(Sex sex, int age, string name, string secondName)
        {
            this.sex = sex;
            Age = age;
            Name = name;
            SecondName = secondName;
        }
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
        public virtual void Information()
        {
            Console.WriteLine($"Info about {Name} {SecondName}:");
            Console.WriteLine($"Age: {Age} \nSex: {sex}");
        }
    };
    class Student : Human
    {
        public Student(Sex sex, int age, string name, string secondName, string university) :
            base(sex, age, name, secondName)
        {
            University = university;
        }
        private string university;
        public string University
        {
            get { return university; }
            set { university = value; }
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
        public Specialist(Sex sex, int age, string name, string secondName, string university, string speciality) :
            base(sex, age, name, secondName, university)
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
