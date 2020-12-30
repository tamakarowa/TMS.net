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
            //remove localization
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("US");

            //set background and Foreground color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            double[,] matrix = new double[0, 0];

            string userSelectWidth;
            long matrixWidth = 1;
            string userSelectLength;
            long matrixLength = 1;

            bool firstRepeat = true;
            bool matrixCheck = true;

            bool repeatMatrixInput = true;

            while (repeatMatrixInput)

            {
                firstRepeat = true;
                repeatMatrixInput = false;
                bool repeatMatrixAction = true;

                WelcomingMessage();

                matrixCheck = false;

                while (firstRepeat)
                {
                    firstRepeat = false;

                    userSelectWidth = MatrixWidthinput().ToUpper();

                    if (userSelectWidth == "CLOSE")
                    {
                        CloseTheApp();
                    }

                    matrixWidth = ParseWidth(userSelectWidth);

                    userSelectLength = MatrixLengthinput().ToUpper();

                    if (userSelectLength == "CLOSE")
                    {
                        CloseTheApp();
                    }

                    matrixLength = ParseLength(userSelectLength);

                    SecondChoise(matrixWidth, matrixLength);

                    firstRepeat = MatrixCheck(ref matrixWidth, ref matrixLength);
                }

                matrix = MatrixInput(matrixWidth, matrixLength);

                Console.WriteLine("\tYour've entered the matrix:");

                MatrixOutput(matrixWidth, matrixLength, matrix);
               
                while (repeatMatrixAction)
                {
                    repeatMatrixAction = false;

                    Console.Clear();

                    Console.WriteLine("\n\tSelect an action you want to do with the matrix: \n\t\t * positive - to find a number of positive numbers \n\t\t * negative - to find a number of negative numbers \n\t\t * ascending - to to sort matrix elements line by line ascending \n\t\t * descending to sort matrix elements line by line descending \n\t\t * inverse - to inverse matrix elements line by line \n\t\t * repeat - to repeat matrix input \n\t\t * close - to close an application");
                    string matrixOperation = Console.ReadLine().ToUpper();

                    switch (matrixOperation)
                    {
                        case "POSITIVE":

                            Console.Clear();

                            Console.WriteLine("\tYour've entered the matrix:");

                            MatrixOutput(matrixWidth, matrixLength, matrix);

                            int positive = 0;

                            positive = Positive(matrixWidth, matrixLength, matrix);

                            Console.WriteLine($"\n\tNumber of positive numbers: {positive} \n");

                            MessageToReturn();

                            Console.ReadKey();

                            repeatMatrixAction = true;

                            break;

                        case "NEGATIVE":

                            Console.Clear();

                            Console.WriteLine("\tYour've entered the matrix:");

                            MatrixOutput(matrixWidth, matrixLength, matrix);

                            int negative = 0;

                            negative = Negative(matrixWidth, matrixLength, matrix);

                            Console.WriteLine($"\n\tNumber of negative numbers: {negative} \n");

                            MessageToReturn();

                            Console.ReadKey();

                            repeatMatrixAction = true;

                            break;

                        case "ASCENDING":

                            Console.Clear();

                            AscendingSort(matrixWidth, matrixLength, matrix);

                            MessageToReturn();

                            Console.ReadKey();

                            repeatMatrixAction = true;

                            break;

                        case "DESCENDING":

                            Console.Clear();

                            DescendingSort(matrixWidth, matrixLength, matrix);

                            MessageToReturn();

                            Console.ReadKey();

                            repeatMatrixAction = true;

                            break;

                        case "INVERSE":

                            Console.Clear();

                            Inverse(matrixWidth, matrixLength, matrix);

                            MessageToReturn();

                            Console.ReadKey();

                            repeatMatrixAction = true;

                            break;

                        case "CLOSE":

                            CloseTheApp();

                            break;

                        case "REPEAT":

                            repeatMatrixInput = true;

                            Console.Clear();

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
            }
        }

        //Welcoming message
        static void WelcomingMessage()
        {
            Console.WriteLine("\tHello User!\n\tWelcome to the Matrix application 1.0! \n\tWith my help you can create a matrix and perform certain actions on it: \n\t\t * to find a number of positive and negative numbers \n\t\t * to sort matrix elements line by line ascending and descending \n\t\t * to inverse matrix elements line by line\n");
        }

        //matrix Width input
        static string MatrixWidthinput()
        {
            Console.WriteLine("\tYou need to select an matrix size. \n\n\t Please type the Length of the matrix with an integer format \n\t(not less than one and not more than 9223372036854775807)\n\t (If you want to close the application please type close)");

            string userSelectWidth = Console.ReadLine();

            return userSelectWidth;
        }

        //to close the app
        static void CloseTheApp()
        {
            Environment.Exit(0);
        }

        //parse the Width
        static long ParseWidth(string userSelectWidth)
        {
            long matrixWidthMethod;
            bool checkWidth;

            do
            {
                checkWidth = Int64.TryParse(userSelectWidth, out matrixWidthMethod);

                if (!checkWidth || (matrixWidthMethod < 1))
                {
                    Console.Clear();
                    Console.WriteLine("\tPlease put correct matrix Length in integer format \n\t(not less than one and not more than 9223372036854775807)");
                    userSelectWidth = Console.ReadLine();
                }

                if (userSelectWidth.ToUpper() == "CLOSE")
                {
                    CloseTheApp();
                }
            }

            while (!checkWidth || (matrixWidthMethod < 1));

            Console.Clear();

            return matrixWidthMethod;
        }

        //matrix Length input
        static string MatrixLengthinput()
        {
            Console.Clear();

            Console.WriteLine("\tNow please type the Length of the matrix with an integer format \n\t(not less than one and not more than 9223372036854775807)\n\t (If you want to close the application please type close)");

            string userSelectLength = Console.ReadLine();

            return userSelectLength;
        }

        //parse the Length
        static long ParseLength(string userSelectLength)
        {
            long matrixLengthMethod;
            bool checkLength;

            do
            {
                checkLength = Int64.TryParse(userSelectLength, out matrixLengthMethod);

                if (!checkLength || (matrixLengthMethod < 1))
                {
                    Console.Clear();
                    Console.WriteLine("\tPlease put correct matrix Length in integer format \n\t(not less than one and not more than 9223372036854775807)");
                    userSelectLength = Console.ReadLine();
                }

                if (userSelectLength.ToUpper() == "CLOSE")
                {
                    CloseTheApp();
                }
            }
            while (!checkLength || (matrixLengthMethod < 1));

            Console.Clear();

            return matrixLengthMethod;
        }

        //menu to fill the matrix
        static void SecondChoise(long matrixWidth, long matrixLength)
        {
            bool restart = false;

            Console.WriteLine($"\tYou select the next dimensions of the Matrix[{matrixWidth},{matrixLength}]. \n\tIf you want to fill the matrix with numbers pleas type anything. \n\tIf you want to close the application please type close.");
            string choiseAfterDimensions = Console.ReadLine();

            if (choiseAfterDimensions.ToUpper() == "CLOSE")
            {
                CloseTheApp();
            }
        }

        //Matrix Check
        static bool MatrixCheck(ref long matrixWidth, ref long matrixLength)
        {
            double[,] matrix = new double[0, 0];
            bool matrixCheck = false;

            try
            {
                //Matrix array
                matrix = new double[matrixWidth, matrixLength];
            }

            catch (OutOfMemoryException ex)
            {
                Console.Clear();
                Console.WriteLine("\n\tYou've inputed too long matrix borders. Your computer cannot calculate it :( \n\tYou'll be returned to the start");
                Console.ReadKey();

                matrixWidth = 0;
                matrixLength = 0;

                return matrixCheck = true;
            }

            catch (OverflowException ex)
            {
                Console.Clear();
                Console.WriteLine("\n\tYou've inputed too long matrix borders. Your computer cannot calculate it :( \n\tYou'll be returned to the start");
                Console.ReadKey();

                matrixWidth = 0;
                matrixLength = 0;

                return matrixCheck = true;
            }

            return matrixCheck;
        }

        //Matrix input
        static public double[,] MatrixInput(long matrixWidth, long matrixLength)
        {
            double[,] matrix = new double[matrixWidth, matrixLength];
            bool matrixElementCheck = true;

            try
            {
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
            }

            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return matrix;
        }

        //matrix output
        static void MatrixOutput(long matrixWidth, long matrixLength, double[,] matrix)
        {
            for (int i = 0; i < matrixWidth; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    Console.Write("\t" + matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //number of positive matrix elements
        static int Positive(long matrixWidth, long matrixLength, double[,] matrix)
        {
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

            return positive;
        }

        //number of negative matrix elements
        static int Negative(long matrixWidth, long matrixLength, double[,] matrix)
        {
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

            return negative;
        }

        //sort ascending
        static void AscendingSort(long matrixWidth, long matrixLength, double[,] matrix)
        {
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

            Console.WriteLine("\tYour matrix after ascending cort:");

            for (int i = 0; i < matrixWidth; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    Console.Write("\t" + matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //sort descending
        static void DescendingSort(long matrixWidth, long matrixLength, double[,] matrix)
        {
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

            Console.WriteLine("\tYour matrix after descending cort:");

            for (int i = 0; i < matrixWidth; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    Console.Write("\t" + matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //Inverse
        static void Inverse(long matrixWidth, long matrixLength, double[,] matrix)
        {
            long arrayMiddle = matrixLength / 2;
            double fake;

            for (int j = 0; j < matrixWidth; j++)
            {
                for (int i = 0; i < arrayMiddle; i++)
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
        }

        static void MessageToReturn()
        {
            Console.WriteLine("\n\tType anything to return chose another action for matrix");
        }
    }
}
