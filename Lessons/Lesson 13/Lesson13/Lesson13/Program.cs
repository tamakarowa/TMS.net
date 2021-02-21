using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            var pers1 = new Person("Tim");
            var emp1 = new Employee("Pqm", "Pm Pam");

            pers1.Display();
            emp1.Display();

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        public virtual void Test()
        {
            Console.WriteLine("Test");
        }



        public override void Display()
        {
            Console.WriteLine($"{Name} working in {Company}");
        }
    }


}
