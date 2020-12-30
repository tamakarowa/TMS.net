using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Class2
    {
        public static void Main(string[] args)  
        {
            var bogdan = new Man(21, "Bogdan", false);
            Console.WriteLine($"Name: {bogdan._name}, Age: {bogdan._age}");
            bogdan.Walk();
            bogdan.WorkHard();
            bogdan.Pee();

            var masha = new Woman();

            Console1.Writeline($"Masha Name: {masha._name}, Age: {masha._age}");

            var max = HumanExtentions.DoSex(bogdan, masha);
            Console.WriteLine($"Max Name: {max._name}, Age: {max._age}");

            Console.ReadLine();
        }
    }
}
