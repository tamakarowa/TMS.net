using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            int matrixWidth = 1;
            int matrixLength = 1;
            bool checkWidth;
            bool checkLength;
            bool matrixElementCheck = true; 

            double[,] matrix = new double[matrixWidth, matrixLength];

            for (int i = 0; i < matrixWidth; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    Console.Write($"{i + 1} line, {j + 1} number = ");
                    var userElementInput = Console.ReadLine().Replace(',', '.');
                    do
                    {
                        matrixElementCheck = Double.TryParse(userElementInput, out matrix[i, j]);

                        if (!matrixElementCheck)
                        {
                            Console.Clear();
                            Console.WriteLine("\tPlease put correct matrix Width in integer format and not less than one: ");
                            userElementInput = Console.ReadLine().Replace(',', '.');
                        }
                    }

                    while (!matrixElementCheck);
                }
            }                
        }
    }
}
