using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace IntroductionToMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework homework = new Homework();
            int sum = 0;
            int product = homework.Lab1(5, 1, 6, out sum);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);

            Cat cat01 = new Cat("Tibby", 2);
            Homework.Age(cat01);
            Homework.Age(cat01);

            var json = new JavaScriptSerializer().Serialize(cat01);
            Console.WriteLine(json);
        }
    }

    class Homework
    {
        public int Lab1(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }

        public static void Age(Cat cat)
        {
            cat.AddAge(5);
        }
    }

    class Cat
    {
        public string name;
        public int age;

        public Cat(string name, int age) { this.name = name; this.age = age; }
        public void AddAge(int value)
        {
            age += value;
        }
    }
}
