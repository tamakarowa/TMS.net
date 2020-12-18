using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ToChek
{
    class Program
    {
        public static void Main(string[] args)
        {
            var y = Invitation();

            Console.ReadLine();            
        }

        public static string Invitation ()
        {
            Text("PmPam");
            Console.WriteLine("Hi");
            var x = Console.ReadLine();
            return x;
        }

        static void Text (string message)
        {
            Console.WriteLine($"message");
        }

        static void ConvertToNumberAndCheck (string y)
        {
            int value;

            if (int.TryParse(y, out value))
            {
                Console.WriteLine($"You've entered {y}");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
        
    }
}
