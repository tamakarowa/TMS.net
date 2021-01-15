using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {

        private int name;

        public int Name2 {get; set;}

        public int Name 
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        static void Main(string[] args)
        {
            //свойства

            var person = new Personcs();

            person.Age = 27;

            Console.WriteLine(person.Age);

            Console.ReadLine();
        }
    }
}
