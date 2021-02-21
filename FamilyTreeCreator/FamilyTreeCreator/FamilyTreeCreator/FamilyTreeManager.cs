using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    class FamilyTreeManager
    {
        public List<Person> People { get; set; }

        public void BuildTree(Guid userId)
        {
            Person person = null;

            foreach (var item in People)
            {
                if (item.Id == userId)
                    person = item;
            }
        }

        public void AddChild(Person wife, Person husband)
        {

        }

        public void Marry(Person man, Person woman)
        {

        }
    }
}
