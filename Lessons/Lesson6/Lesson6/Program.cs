using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {

            var Str = Console.ReadLine();
            var Option = int.Parse(Str);

            var option = (AriphmAction)Option;

            //////for switch
            case AriphmAction.Plus;


                Console.Read();
        }

        public static void Number (Gender option)
        {
            if (option==Gender.Male)
                Console.WriteLine(Gender.Male);
            else if (option == Gender.Female)
                Console.WriteLine(Gender.Male);
            else
                Console.WriteLine(Gender.Other);
        }


        static int Factorial (int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }             
        }

        public enum Gender
        {
            Male,
            Female,
            Other
        }

        public enum AriphmAction
        {
            Plus,
            Minys,
            Devide,
            Multiply
        }
    }

   
}
