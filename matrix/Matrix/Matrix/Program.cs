using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //remove localization
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("US");

            //set background and Foreground color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //matrix elements
            int matrixWidth = 1;
            int matrixLength = 1;
            bool checkWidth;
            bool checkLength;
            
            //Welcoming message
            Console.WriteLine("\tHello User!\n\tWelcome to the Matrix application 1.0! \n\tWith my help you can create a matrix and perform certain actions on it: \n\t\t * to find a number of positive and negative numbers \n\t\t * to sort matrix elements line by line ascending and descending \n\t\t * to inverse matrix elements line by line");


            //repeat Width and Length input
            bool repeatDimensions = false;
            string choiseAfterDimensions;

            do
            {
                //reset of repeating this block of code
                repeatDimensions = false;

                //matrix Width input
                Console.WriteLine("\n\tYou need to select an matrix size. \n\n\t Please type the Length of the matrix with an integer format and not less than one: \n\t (If you want to close the application please type close)");

                string userSelectWidth = Console.ReadLine();

                //close the app 
                if (userSelectWidth.ToLower() == "close")
                {
                    Environment.Exit(0);
                }

                //Check for matrix Width
                do
                {
                    checkWidth = Int32.TryParse(userSelectWidth, out matrixWidth);

                    if (!checkWidth || (matrixWidth < 1))
                    {
                        Console.Clear();
                        Console.WriteLine("\tPlease put correct matrix Length in integer format and not less than one: ");
                        userSelectWidth = Console.ReadLine();
                    }

                }
                while (!checkWidth || (matrixWidth < 1));

                //matrix Length input
                Console.Clear();
                Console.WriteLine("\tNow please type the Width of the matrix with an integer format and not less than one: \n\t (If you want to close the application please type close)");

                string userSelectLength = Console.ReadLine();

                //close the app 
                if (userSelectLength.ToLower() == "close")
                {
                    Environment.Exit(0);
                }

                //Check for matrix Length
                do
                {
                    checkLength = Int32.TryParse(userSelectLength, out matrixLength);

                    if (!checkLength || (matrixLength < 1))
                    {
                        Console.Clear();
                        Console.WriteLine("\tPlease put correct matrix Width in integer format and not less than one: ");
                        userSelectLength = Console.ReadLine();
                    }

                }
                while (!checkLength || (matrixLength < 1));

                //filling the matrix
                Console.Clear();
                Console.WriteLine($"\tYou select the next dimensions of the Matrix[{matrixWidth},{matrixLength}]. \n\tIf you want to fill the matrix with numbers pleas type anything. \n\tIf you want to redefine the dimensions of the matrix, please type restart. If you want to close the application please type close.");
                choiseAfterDimensions = Console.ReadLine();
                if (choiseAfterDimensions.ToLower() == "close")
                {
                    Environment.Exit(0);
                }
                else if (choiseAfterDimensions.ToLower() == "restart")
                {
                    Console.Clear();
                    repeatDimensions = true;
                }

            } while (repeatDimensions);

            int matrixVolume = matrixWidth * matrixLength;
            Console.Clear();
            Console.WriteLine($"\tTo fill the matrix please enter {matrixVolume} numbers:");

            //Matrix array
            double[,] matrix = new double[matrixWidth, matrixLength];

            bool matrixElementCheck = true;

            //Matrix input
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
                            Console.Write($"Please put correct { i + 1} line, { j + 1} number = ");
                            userElementInput = Console.ReadLine().Replace(',', '.');
                        }
                    }

                    while (!matrixElementCheck);
                }
            }
            Console.WriteLine();

            //Matrix output
            Console.Clear();

            Console.WriteLine("\tYour've entered the matrix:");

            for (int i = 0; i < matrixWidth; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    Console.Write("\t" + matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //bool for repeat matrix operation
            bool repeatMatrixAction = false;

            do
            {
                repeatMatrixAction = false;

                Console.WriteLine("\n\tSelect the action you want to do with the matrix: \n\t\t * Type positive or negative to find a number of positive and negative numbers \n\t\t * Type ascending or descending to sort matrix elements line by line ascending and descending \n\t\t * Type inverse to inverse matrix elements line by line \n\t\t * Type close to close an application");
                string matrixOperation = Console.ReadLine();

                switch (matrixOperation.ToLower())
                {
                    case "positive":

                        Console.Clear();

                        Console.WriteLine("\tYou're matrix matrix:");

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                Console.Write("\t" + matrix[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        int positive = 0;

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                if (matrix[i, j] >= 0)
                                {
                                    positive++;
                                }
                            }
                        }

                        Console.WriteLine($"\n\tNumber of positive numbers: {positive} \n");
                        repeatMatrixAction = true;

                        break;

                    case "negative":

                        Console.Clear();

                        Console.WriteLine("\tYou're matrix:");

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                Console.Write("\t" + matrix[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        int negative = 0;

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                if (matrix[i, j] < 0)
                                {
                                    negative++;
                                }
                            }
                        }

                        Console.WriteLine($"\n\tNumber of negative numbers: {negative} \n");
                        repeatMatrixAction = true;

                        break;

                    case "ascending":

                        Console.Clear();

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                for (int f = 0; f < matrixLength; f++)
                                {
                                    if (matrix[i, j] <= matrix[i, f])
                                    {
                                        var fakeSort = matrix[i, j];
                                        matrix[i, j] = matrix[i, f];
                                        matrix[i, f] = fakeSort;
                                    }
                                }
                            }
                        }

                        Console.WriteLine("\tYou're matrix after ascending cort:");

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                Console.Write("\t" + matrix[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        repeatMatrixAction = true;

                        break;

                    case "descending":

                        Console.Clear();

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                for (int f = 0; f < matrixLength; f++)
                                {
                                    if (matrix[i, j] >= matrix[i, f])
                                    {
                                        var fakeSort = matrix[i, j];
                                        matrix[i, j] = matrix[i, f];
                                        matrix[i, f] = fakeSort;
                                    }
                                }
                            }
                        }

                        Console.WriteLine("\tYou're matrix after descending cort:");

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                Console.Write("\t" + matrix[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        repeatMatrixAction = true;

                        break;

                    case "inverse":

                        Console.Clear();

                        int arrayMidle = matrixLength / 2;          
                        double fake;             

                        for (int j = 0; j < matrixWidth; j++)
                        {
                            for (int i = 0; i < arrayMidle; i++)
                            {
                                fake = matrix[j, i];
                                matrix[j, i] = matrix[j, matrixLength - i - 1];
                                matrix[j, matrixLength - i - 1] = fake;
                            }
                        }

                        for (int i = 0; i < matrixWidth; i++)
                        {
                            for (int j = 0; j < matrixLength; j++)
                            {
                                Console.Write("\t" + matrix[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        repeatMatrixAction = true;

                        break;

                    case "close":

                        Environment.Exit(0);

                        break;

                    default:

                        //wrong input
                        Console.Clear();
                        Console.WriteLine("\n\tYou've entered unknown operation. \n\tPlease type any key and you will be redirected to matrix operation selection menu");
                        var wrongInput = Console.ReadKey();
                        repeatMatrixAction = true;

                        break;
                }
            }
            while (repeatMatrixAction);

            Console.ReadLine();
               
        }
    }
}
