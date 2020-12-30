using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class Human
    {

        public int _age { get; set; }
        public string _name { get; set; }

        public string Eat ()
        {
            return "Trash";
        }
        public void Walk()
        {
            Console.WriteLine("Move");
        }

        public virtual void Pee()
        {
            Console.WriteLine("Basic realization");
        }

       
    }
}
