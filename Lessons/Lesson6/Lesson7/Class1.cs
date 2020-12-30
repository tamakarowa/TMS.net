using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class Man: Human 
    {
        public bool _IsHasBeerd { get; set; }

        public void WorkHard ()
        {
            Console.WriteLine("Hard Work!");
        }


        public  Man(int age, string name, bool IsHasBeerd)
        {
           _age = age;
            _name = name;
            _IsHasBeerd = IsHasBeerd;
        }

        public override void Pee()
        {
            Console.WriteLine("Pee like a man");
        }
    }
}
