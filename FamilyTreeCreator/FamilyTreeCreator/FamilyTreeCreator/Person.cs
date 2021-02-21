using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    public class Person
    {
        public Guid Id { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }

        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }

        public bool IsWoman { get; set; }

        public static Person CreateChildren(Person mother, Person father)
        {
            return new Person();
        }
    }
}
