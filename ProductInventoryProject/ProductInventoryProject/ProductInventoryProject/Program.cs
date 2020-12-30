using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject
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

            bool returnToMainMenu = true;

            int numberOfApples = 0;
            int numberOfPears = 0;
            int numberOfOrange = 0;
            int numberOfGrape = 0;
            int numberOfPeach = 0;

            while (returnToMainMenu)
            {
                returnToMainMenu = false; 

                Console.Clear();

                MainMenu();

                string userInput = UserInput();

                int correctUserInput = Parsing(userInput);

                string numberInput;

                switch (correctUserInput)
                {
                    case (int)Menu.Apple:

                        Console.Clear();

                        Console.WriteLine("\t\tPlease enter number of apples");                        

                        var appleUserInput = Console.ReadLine();

                        numberOfApples = NumberParsing(appleUserInput);                        

                        InfoMessage();

                        returnToMainMenu = true; 

                        break;

                    case (int)Menu.Pear:

                        Console.Clear();

                        Console.WriteLine("\t\tPlease enter number of pears");                        

                        var pearUserInput = Console.ReadLine();

                        numberOfPears = NumberParsing(pearUserInput);                        

                        InfoMessage();

                        returnToMainMenu = true;

                        break;

                    case (int)Menu.Orange:

                        Console.Clear();

                        Console.WriteLine("\t\tPlease enter number of oranges");                        

                        var orangeUserInput = Console.ReadLine();

                        numberOfOrange = NumberParsing(orangeUserInput);                       

                        InfoMessage();

                        returnToMainMenu = true;

                        break;

                    case (int)Menu.Grape:

                        Console.Clear();

                        Console.WriteLine("\t\tPlease enter number of grapes");                        

                        var grapeUserInput = Console.ReadLine();

                        numberOfGrape = NumberParsing(grapeUserInput);                        

                        InfoMessage();

                        returnToMainMenu = true;

                        break;

                    case (int)Menu.Peach:

                        Console.Clear();

                        Console.WriteLine("\t\tPlease enter number of peaches");                       

                        var peachUserInput = Console.ReadLine();

                        numberOfPeach = NumberParsing(peachUserInput);                        

                        InfoMessage();

                        returnToMainMenu = true;

                        break;

                    case (int)Menu.Report:

                        new Report(numberOfApples, numberOfPears, numberOfOrange, numberOfGrape, numberOfPeach);

                        Console.Clear();
                        
                        returnToMainMenu = true;

                        break;

                    case (int)Menu.Close:

                        CloseTheApp();

                        break;
                }
            }
        }

        //The first menu
        static void MainMenu ()
        {
            Console.WriteLine("\n\t\tPlease select the fruit to set the quantity:");
            Console.WriteLine("\n\t\t1 for Apple" +
                "\n\t\t2 for Pear" +
                "\n\t\t3 for Orange" +
                "\n\t\t4 for Grape" +
                "\n\t\t5 for Peach" +
                "\n\n\t\t6 for look at report" +
                "\n\n\t\t7 to close the app");            
        }

        static string UserInput ()
        {
            string userInput = null;

            userInput = Console.ReadLine();

            return userInput;
        }

        public enum Menu : int
        {
            Apple =1,
            Pear,
            Orange,
            Grape,
            Peach,
            Report,
            Close
        }

        //to close the app
        static void CloseTheApp()
        {
            Environment.Exit(0);
        }

        static void InfoMessage ()
        {
            Console.WriteLine("\n\t\tYou're input was saved. \n\t\tType any key to return to the menu.");

            Console.ReadKey();
        }

        //parse the user input
        static int Parsing(string userInput)
        {
            int correctUserInput;
            bool checkInput;

            do
            {
                checkInput = Int32.TryParse(userInput, out correctUserInput);

                if (!checkInput || (correctUserInput < 1) || (correctUserInput > 7))
                {    
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();

                    Console.WriteLine("\t\tYou've tipped unknown command. Please put the correct option");

                    Console.ForegroundColor = ConsoleColor.Black;          

                    MainMenu();

                    userInput = Console.ReadLine();
                }

                if (userInput.ToUpper() == "7")
                {
                    CloseTheApp();
                }
            }

            while (!checkInput || (correctUserInput < 1));

            Console.Clear();

            return correctUserInput;
        }

        //parse the number input
        static int NumberParsing(string numberInput)
        {
            int correctUserInput;
            bool checkInput;

            do
            {
                checkInput = Int32.TryParse(numberInput, out correctUserInput);

                if (!checkInput)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();

                    Console.WriteLine("\t\tYou've tipped invalid value. Please put the correct number of fructs (intager format)");

                    Console.ForegroundColor = ConsoleColor.Black;            

                    numberInput = Console.ReadLine();
                }                
            }

            while (!checkInput);

            Console.Clear();

            return correctUserInput;
        } 
    }
}  
