using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            double userInput1;
            double userInput2;
            double result = 0;
            bool repeatOperation = false;
            bool backToStart = false;
            string userNextChoice;
            int i = 0;

            // Array with user results
            double[] resultsHolder = new double[5];

            string userFirstVariable;
            string userSecondVariable;
            bool checkFirstInput;
            bool checkSecongInput;


            //number input
            Console.Clear();
            Console.WriteLine("\tYou've chosen square root calculation. \n\t Please type enter the number from which you want to calculate the square root (cannot be negative)");

            userFirstVariable = Console.ReadLine().Replace(',', '.');

            do
            {
                checkFirstInput = Double.TryParse(userFirstVariable, out userInput1);

                if (!checkFirstInput)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter correct number from which you want to calculate the square root (cannot be negative): ");
                    userFirstVariable = Console.ReadLine().Replace(',', '.');
                }

            }
            while (!checkFirstInput);

            //divider input
            Console.Clear();
            Console.WriteLine("\t Please type divider");

            userSecondVariable = Console.ReadLine().Replace(',', '.');

            do
            {
                checkSecongInput = Double.TryParse(userSecondVariable, out userInput2);

                if (!checkSecongInput || (userInput2 == 0))
                {
                    Console.Clear();
                    Console.WriteLine("\tPlease put correct divider or nonzero divider: ");
                    userSecondVariable = Console.ReadLine().Replace(',', '.');
                }

            }
            while (!checkSecongInput);
        }
    }
}
