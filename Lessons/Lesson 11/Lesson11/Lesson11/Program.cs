using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{ 
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class People
    {
        Person[] data;
        public People()
        {
            data = new Person[5];
        }

        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public Person this[string name]
        {
            get
            {
                Person person = null;
                foreach (var p in data)
                {
                    if (p?.Name == name)
                    {
                        person = p;
                        break;
                    }
                }
                return person;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[0] = new Person { Name = "Tom" };
            people[1] = new Person { Name = "Bob" };

            Console.WriteLine(people[0].Name);      // Tom
            Console.WriteLine(people["Bob"].Name);  // Bob

            Console.ReadKey();
        }
    }
}
