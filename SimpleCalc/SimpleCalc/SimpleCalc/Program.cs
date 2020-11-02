using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
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

            //declaration of variables
            double userInput1; 
            double userInput2; 
            double result = 0;
            bool repeatOperation = false; 
            bool backToStart = false; 
            string userNextChoice;
            string userFirstVariable;
            string userSecondVariable;
            bool checkFirstInput;
            bool checkSecongInput;

            // Array with user results
            double[] resultsHolder = new double[5];
            int i = 0;

            //welcome message
            Console.WriteLine("\tHello User!\n\tWelcome to the Simple Calculator application 1.0! \n\n\tWith my help you can calculate the following operations: \n\taddition, subtraction, multiplication, division, square root calculation, percentage calculation\n");     
            
            do
            {
                //Chose an action
                Console.WriteLine("\tIf you want to perform addition operation please type + and press Enter \n\tIf you want to perform subtraction operation please type - and press Enter \n\tIf you want to perform multiplication operation please type * and press Enter \n\tIf you want to perform division operation please type / and press Enter \n\tIf you want to perform square root calculation please type sqrt and press Enter \n\tIf you want to perform percentage calculation please type % and press Enter \n\n\tif you want to see the results of the last five operations, press Results \n\n\tIf you want to close the application please type close and press Enter");

                string userChoice = Console.ReadLine();

                //close the app 
                if (userChoice.ToLower() == "close")
                {
                    Environment.Exit(0);
                }

                //to show last 5 results
                else if (userChoice.ToLower() == "results")
                {
                    Console.Clear();
                    Console.WriteLine("Please NOTE: if the number of operations is more than five, the previous operations are overwritten by the subsequent ones");
                    Console.WriteLine($"\n\tResult of the first operation = {resultsHolder[0]} \n\tResult of the second operation = {resultsHolder[1]} \n\tResult of the third operation = {resultsHolder[2]} \n\tResult of the fourth operation = {resultsHolder[3]} \n\tResult of the fourth fifth = {resultsHolder[4]}");
                    Console.WriteLine("\n\tIf you want to perform addition operation please type + and press Enter \n\tIf you want to perform subtraction operation please type - and press Enter \n\tIf you want to perform multiplication operation please type * and press Enter \n\tIf you want to perform division operation please type / and press Enter \n\tIf you want to perform square root calculation please type sqrt and press Enter \n\tIf you want to perform percentage calculation please type % and press Enter \n\n\tIf you want to close the application please type close and press Enter");
                    userChoice = Console.ReadLine();
                   
                    //close the app 
                    if (userChoice.ToLower() == "close")
                    {
                        Environment.Exit(0);
                    }

                }

                //available operations
                switch (userChoice)
                {
                    case "+":  

                        do {
                            //first term input
                            Console.Clear();
                            Console.WriteLine("\tYou've chosen addition operation. \n\t Please type the first term");

                            userFirstVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {                                
                                checkFirstInput = Double.TryParse(userFirstVariable, out userInput1);

                                if (!checkFirstInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put correct first term: ");
                                    userFirstVariable = Console.ReadLine().Replace(',', '.');
                                }

                            }
                            while (!checkFirstInput);

                            //second term input
                            Console.Clear();
                            Console.WriteLine("\tPlease type the second term");

                            userSecondVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkSecongInput = Double.TryParse(userSecondVariable, out userInput2);

                                if (!checkSecongInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put correct second term: ");
                                    userSecondVariable = Console.ReadLine().Replace(',', '.');
                                }

                            }
                            while (!checkSecongInput);

                            try
                            {
                                //addition operation
                                result = userInput1 + userInput2;

                                //putting the result into the array
                                resultsHolder[i] = result;
                                i = ++i;

                                //array overload
                                if (i == 5)
                                {
                                    i = 0;
                                }

                                Console.Clear();
                                Console.WriteLine($"\t The result of addition operation : {userInput1} + {userInput2} = {result}");
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            //further user actions
                            Console.WriteLine("\n\tIf you want to repeat addition operation type repeat. \n\tIf you want to select another operation type toStart. \n\tIf you want to look at 5 last results type results. \n\tyou want to close the application type close.");
                            userNextChoice = Console.ReadLine();
                            
                            switch (userNextChoice.ToLower())
                            {
                                case "repeat":
                                    backToStart = false;
                                    repeatOperation = true;
                                    break;

                                case "tostart":
                                    repeatOperation = false;
                                    backToStart = true;
                                    Console.Clear();
                                    break;

                                case "close":
                                    Environment.Exit(0);
                                    break;
         
                                default:
                                    Console.WriteLine("The input was wrong. Application will be closed.");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                    break; 
                            }

                        } while (repeatOperation);

                        break;

                    case "-":

                        do
                        {
                            ///minuend input
                            Console.Clear();
                            Console.WriteLine("\tYou've chosen subtraction operation. \n\t Please type the minuend");

                            userFirstVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkFirstInput = Double.TryParse(userFirstVariable, out userInput1);

                                if (!checkFirstInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put correct minuend: ");
                                    userFirstVariable = Console.ReadLine().Replace(',', '.');
                                }

                            }
                            while (!checkFirstInput);

                            //subtraction input
                            Console.Clear();
                            Console.WriteLine("\tPlease type the subtraction");

                            userSecondVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkSecongInput = Double.TryParse(userSecondVariable, out userInput2);

                                if (!checkSecongInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put correct subtraction: ");
                                    userSecondVariable = Console.ReadLine().Replace(',', '.');
                                }

                            }
                            while (!checkSecongInput);

                            try
                            {
                                //subtraction operation
                                result = userInput1 - userInput2;

                                //putting the result into the array
                                resultsHolder[i] = result;
                                i = ++i;

                                //array overload
                                if (i == 5)
                                {
                                    i = 0;
                                }

                                Console.Clear();
                                Console.WriteLine($"\t The result of addition operation : {userInput1} - {userInput2} = {result}");
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            //further user actions
                            Console.WriteLine("\n\tIf you want to repeat subtraction operation type repeat. \n\tIf you want to select another operation type toStart. \n\tyou want to close the application type close.");
                            userNextChoice = Console.ReadLine();
                            switch (userNextChoice.ToLower())
                            {
                                case "repeat":
                                    backToStart = false;
                                    repeatOperation = true;
                                    break;

                                case "tostart":
                                    repeatOperation = false;
                                    backToStart = true;
                                    Console.Clear();
                                    break;

                                case "close":
                                    Environment.Exit(0);
                                    break;

                                default:
                                    Console.WriteLine("The input was wrong. Application will be closed.");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                    break;
                            }

                        } while (repeatOperation);

                        break;

                    case "*":

                        do
                        {
                            //first multiply input
                            Console.Clear();
                            Console.WriteLine("\tYou've chosen multiplication operation. \n\t Please type the first multiply");

                            userFirstVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkFirstInput = Double.TryParse(userFirstVariable, out userInput1);

                                if (!checkFirstInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put correct first multiply: ");
                                    userFirstVariable = Console.ReadLine().Replace(',', '.');
                                }

                            }
                            while (!checkFirstInput);

                            //second multiply input
                            Console.Clear();
                            Console.WriteLine("\tPlease type the second multiply");

                            userSecondVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkSecongInput = Double.TryParse(userSecondVariable, out userInput2);

                                if (!checkSecongInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put correct second multiply: ");
                                    userSecondVariable = Console.ReadLine().Replace(',', '.');
                                }

                            }
                            while (!checkSecongInput);

                            try
                            {
                                //multiplication operation
                                result = userInput1 * userInput2;

                                //putting the result into the array
                                resultsHolder[i] = result;
                                i = ++i;

                                //array overload
                                if (i == 5)
                                {
                                    i = 0;
                                }

                                Console.Clear();
                                Console.WriteLine($"\t The result of multiplication operation : {userInput1} * {userInput2} = {result}");
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            //further user actions
                            Console.WriteLine("\n\tIf you want to repeat multiplication operation type repeat. \n\tIf you want to select another operation type toStart. \n\tyou want to close the application type close.");
                            userNextChoice = Console.ReadLine();
                            switch (userNextChoice.ToLower())
                            {
                                case "repeat":
                                    backToStart = false;
                                    repeatOperation = true;
                                    break;

                                case "tostart":
                                    repeatOperation = false;
                                    backToStart = true;
                                    Console.Clear();
                                    break;

                                case "close":
                                    Environment.Exit(0);
                                    break;

                                default:
                                    Console.WriteLine("The input was wrong. Application will be closed.");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                    break;
                            }
                        } while (repeatOperation);

                        break;

                    case "/":

                        do
                        {
                            //dividend input
                            Console.Clear();
                            Console.WriteLine("\tYou've chosen division operation. \n\t Please type the dividend");

                            userFirstVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkFirstInput = Double.TryParse(userFirstVariable, out userInput1);

                                if (!checkFirstInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put correct dividend: ");
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
                            while (!checkSecongInput || (userInput2 == 0));

                            try
                            {
                                //division operation
                                result = userInput1 / userInput2;

                                //putting the result into the array
                                resultsHolder[i] = result;
                                i = ++i;

                                //array overload
                                if (i == 5)
                                {
                                    i = 0;
                                }

                                Console.Clear();
                                Console.WriteLine($"\t The result of division operation : {userInput1} / {userInput2} = {result}");
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            //further user actions
                            Console.WriteLine("\n\tIf you want to repeat division operation type repeat. \n\tIf you want to select another operation type toStart. \n\tyou want to close the application type close.");
                            userNextChoice = Console.ReadLine();
                            switch (userNextChoice.ToLower())
                            {
                                case "repeat":
                                    backToStart = false;
                                    repeatOperation = true;
                                    break;

                                case "tostart":
                                    repeatOperation = false;
                                    backToStart = true;
                                    Console.Clear();
                                    break;

                                case "close":
                                    Environment.Exit(0);
                                    break;

                                default:
                                    Console.WriteLine("The input was wrong. Application will be closed.");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                    break;
                            }

                        } while (repeatOperation);

                        break;

                    case "%":

                        do
                        {
                            //number input
                            Console.Clear();
                            Console.WriteLine("\tYou've chosen percentage calculation. \n\t Please type the percentage (without % sign)");

                            userFirstVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkFirstInput = Double.TryParse(userFirstVariable, out userInput1);

                                if (!checkFirstInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put correct percentage (without % sign): ");
                                    userFirstVariable = Console.ReadLine().Replace(',', '.');
                                }

                            }
                            while (!checkFirstInput);

                            //percent input
                            Console.Clear();
                            Console.WriteLine("\tPlease type the nuber from what the percentage will be calculated");

                            userSecondVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkSecongInput = Double.TryParse(userSecondVariable, out userInput2);

                                if (!checkSecongInput)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease put nuber from what the percentage will be calculated: ");
                                    userSecondVariable = Console.ReadLine().Replace(',', '.');
                                }

                            }
                            while (!checkSecongInput);

                            try
                            {
                                //percentage calculation
                                result = userInput1 * userInput2 / 100;

                                //putting the result into the array
                                resultsHolder[i] = result;
                                i = ++i;

                                //array overload
                                if (i == 5)
                                {
                                    i = 0;
                                }

                                Console.Clear();
                                Console.WriteLine($"\t The result of percentage calculation : {userInput1}% * {userInput2} /100 %= {result}");
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            //further user actions
                            Console.WriteLine("\n\tIf you want to repeat percentage calculation type repeat. \n\tIf you want to select another operation type toStart. \n\tyou want to close the application type close.");
                            userNextChoice = Console.ReadLine();
                            switch (userNextChoice.ToLower())
                            {
                                case "repeat":
                                    backToStart = false;
                                    repeatOperation = true;
                                    break;

                                case "tostart":
                                    repeatOperation = false;
                                    backToStart = true;
                                    Console.Clear();
                                    break;

                                case "close":
                                    Environment.Exit(0);
                                    break;

                                default:
                                    Console.WriteLine("The input was wrong. Application will be closed.");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                    break;
                            }

                        } while (repeatOperation);

                        break;

                    case "sqrt":

                        do
                        {
                            //number input
                            Console.Clear();
                            Console.WriteLine("\tYou've chosen square root calculation. \n\t Please type enter the number from which you want to calculate the square root (cannot be negative)");

                            userFirstVariable = Console.ReadLine().Replace(',', '.');

                            do
                            {
                                checkFirstInput = Double.TryParse(userFirstVariable, out userInput1);

                                if (!checkFirstInput || (userInput1 < 0))
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tPlease enter correct number from which you want to calculate the square root (cannot be negative): ");
                                    userFirstVariable = Console.ReadLine().Replace(',', '.');                                   
                                }

                            }
                            while (!checkFirstInput || (userInput1 < 0));

                            try
                            {
                                //percentage calculation
                                result = Math.Sqrt(userInput1);

                                //putting the result into the array
                                resultsHolder[i] = result;
                                i = ++i;

                                //array overload
                                if (i == 5)
                                {
                                    i = 0;
                                }

                                Console.Clear();
                                Console.WriteLine($"\t The square root from {userInput1} = {result}");
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            //further user actions
                            Console.WriteLine("\n\tIf you want to repeat square root calculation type repeat. \n\tIf you want to select another operation type toStart. \n\tyou want to close the application type close.");
                            userNextChoice = Console.ReadLine();
                            switch (userNextChoice.ToLower())
                            {
                                case "repeat":
                                    backToStart = false;
                                    repeatOperation = true;
                                    break;

                                case "tostart":
                                    repeatOperation = false;
                                    backToStart = true;
                                    Console.Clear();
                                    break;

                                case "close":
                                    Environment.Exit(0);
                                    break;

                                default:
                                    Console.WriteLine("The input was wrong. Application will be closed.");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                    break;
                            }

                        } while (repeatOperation);

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\tYou've put unknown operation type. \n\tIf you want to re-enter the operation type anything. \n\tIf you want to close the application type close");

                        var invalidInput = Console.ReadLine();

                        //close the app 
                        if (invalidInput.ToLower() == "close")
                        {
                            Environment.Exit(0);
                        }

                        else
                        {
                            Console.Clear();
                            backToStart = true;
                        }

                        break;
                }                
            }           
            while (backToStart);
        }
    }
}
