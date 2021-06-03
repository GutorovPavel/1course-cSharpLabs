using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    enum sexEnum
    {
        Male,
        Female,
        Undefined
    }
    abstract class Human : IInformation
    {
        public Human(sexEnum sex, int age, string name, string secondName, int sum)
        {
            Sex = sex;
            Age = age;
            Name = name;
            SecondName = secondName;
            Sum = sum;
        }
        private sexEnum sex;
        public sexEnum Sex
        {
            get { return sex; }
            set { sex = value; }
        }

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
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine($"Info about {Name} {SecondName}:");
            try
            {
                if (Age <= 0)
                {
                    throw new Exception($"Age must be positive. Your input: {Age}");
                }
                else
                    Console.WriteLine($"Age: {Age}");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {e.Message}");
                Console.ResetColor();
            }
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"The amount of money in the account: {Sum}");
        }
 
        //ACCOUNT EVENTS
        public delegate void AccountEvents(string notifications);
        public event AccountEvents Notify;

        private int sum;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public void Purchase(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Withdrawn from the account: {sum}");
                Console.WriteLine($"Current balance: {Sum}\n");
            }
            else
            {
                Notify?.Invoke($"Attempted to spend {sum}\nNot enough money, current balance: {Sum}\n");
            }
        }
        public void BalanceReplenishment(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"The balance was replenished by the amount: {sum}");
            Console.WriteLine($"Current balance: {Sum}\n");
        }
    }
}
