using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    class Father : Person
    {
        public bool IsFather { get; set; }

        public Mother Wife { get; set; }

        public void EarnMoney()
        {
            Console.WriteLine("Work hard!");
        }
        
        // нарисовал декоратор/обертку из интернет
        private Person _person;

        public Father (Person person)
        {
            _person = person;
        }

        public Father()
        {

        }
    }
}
