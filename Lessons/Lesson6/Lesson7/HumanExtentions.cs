using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public static class HumanExtentions
    {
        public static Man DoSex (Man man, Woman woman)
        {

            Console.WriteLine("9 month later");
            return new Man(0, "Maximka", false); 
        }
    }
}
