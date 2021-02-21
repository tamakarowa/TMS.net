using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    class Mother : Person
    {
        public bool IsMother { get; set; }

        public Father Husband { get; set; }

        public void Care()
        {
            Console.WriteLine("Care!");
        }

        // нарисовал декоратор/обертку из интернет
        private Person _person;

        public Father(Person person)
        {
            _person = person;
        }

        public Father()
        {

        }
    }
}
