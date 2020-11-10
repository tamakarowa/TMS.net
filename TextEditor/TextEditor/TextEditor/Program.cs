using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using System.Collections.Concurrent;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            //set background and Foreground color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //welcoming message
            Console.WriteLine("\tHello User!");

            bool toRepeatLineInput = true;

            while (toRepeatLineInput)
            {
                //reset bool
                toRepeatLineInput = false;

                string userMainInput = null;
               
                //the path to the file
                string path = @"D:\C#\Projects\TextEditor\TextFile.txt";

                bool wayToWorkWithText = true;

                while (wayToWorkWithText)
                {
                    wayToWorkWithText = false;

                    Console.WriteLine("\tPlease choose a way to work with text:");
                    Console.WriteLine($"\n\t1 - to work with a Text File {path}");
                    Console.WriteLine("\t2 - enter a line with a console");

                    string fileOrConsole = Console.ReadLine();

                    if (fileOrConsole == "1")
                    {
                        try
                        {
                            using (StreamReader sr = new StreamReader(path))
                            {
                                userMainInput = (sr.ReadToEnd());
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"File {path} not found. PLease enter the text into the console.");

                        }
                    }

                    else if (fileOrConsole == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("\tPlease enter the line you want to work with (not allowed to contain Cyrillic):");
                        userMainInput = Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Your input was wrong. Please input a correct key");
                        wayToWorkWithText = true;
                    }

                    //Reges for Cyrillic unput
                    string reg = @"\P{IsBasicLatin}";

                    //if line contain Cyrillic - true
                    bool res = Regex.Match(userMainInput, reg).Success;

                    //error message for wrong input
                    if (res)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("Your input contain Cyrillic. Please put correct text.");
                        Console.ForegroundColor = ConsoleColor.Black;

                        wayToWorkWithText = true;
                    }
                }

                //main menu
                bool returnToMainMenu = true;

                while (returnToMainMenu)
                {
                    returnToMainMenu = false;

                    Console.Clear();
                    Console.WriteLine($"\tPlease select an action you want to make with the line: \n\t{userMainInput}");
                    Console.WriteLine("\n\t 1 - to find words with maximum number of digits.");
                    Console.WriteLine("\t 2 - to find the longest word and determine how many times it appears in the text.");
                    Console.WriteLine("\t 3 - to replace numbers from 0 to 9 with the words.");
                    Console.WriteLine("\t 4 - to display interrogative sentences first and then exclamation sentences.");
                    Console.WriteLine("\t 5 - to display only sentences that do not contain commas.");
                    Console.WriteLine("\t 6 - to find words starting and ending with the same letter.");
                    Console.WriteLine("\n\t 7 - to repeat line input.");
                    Console.WriteLine("\n\t 8 - to close the application.");

                    //action input            
                    var userChoise = Console.ReadLine();

                    switch (userChoise)
                    {
                        //to find the maximum number of digits
                        case "1":

                            Console.Clear();

                            string string1 = userMainInput;
                            string munsChech = (@"[\d]");

                            bool lineContainNums = Regex.Match(string1, munsChech).Success;

                            if (lineContainNums)
                            {
                                string numbers = "0123456789";
                                string[] lineToWordArr1 = string1.Split(' ', '\t', ',', '.', '!', '?', ':', ';', '\n');
                                int numberOfSymbols = lineToWordArr1.Length;
                                int[] wordsWithNumbers = new int[numberOfSymbols];

                                //to found words with numbers
                                for (int i = 0; i < numberOfSymbols; ++i)
                                {
                                    for (int j = 0; j < lineToWordArr1[i].Length; ++j)
                                        if (numbers.IndexOf(lineToWordArr1[i][j]) != -1)
                                            wordsWithNumbers[i]++;
                                }

                                //comparison
                                int maxNumbers = wordsWithNumbers[0];

                                for (int i = 1; i < numberOfSymbols; ++i)
                                {
                                    if (wordsWithNumbers[i] > maxNumbers)
                                    {
                                        maxNumbers = wordsWithNumbers[i];
                                    }
                                }

                                //output
                                Console.WriteLine("\tWords with maximum number of digits:\n");

                                for (int i = 0; i < numberOfSymbols; ++i)
                                {
                                    if (wordsWithNumbers[i] == maxNumbers)
                                    {
                                        Console.WriteLine($"\t{lineToWordArr1[i]}");
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("\n\tYour line don't contain numbers.");
                            }

                            returnToMainMenu = true;

                            Console.WriteLine("\n\tType anything to returt to main menu");
                            Console.ReadKey();

                            break;

                        //to find the longest word and determine how many times it appears in the text
                        case "2":

                            Console.Clear();

                            var string2 = userMainInput;                            
                            string2 = string2.ToLower();

                            string[] lineToWordArr2 = string2.Split(' ', '\t', ',', '.', '!', '?', ':', ';', '\n');
                            int numWorsInArray = lineToWordArr2.Length;
                            int[] theLongestWord = new int[numWorsInArray];

                            if (String.IsNullOrEmpty(string2))
                            {
                                Console.WriteLine("\n\tYou've entered an empty line.");
                            }

                            else
                            {
                                //array without duplicates
                                string[] arrayWithoutDuplicates = lineToWordArr2.Distinct().ToArray();
                                int numberOfSymbolsNoDupl = arrayWithoutDuplicates.Length;

                                //to found the longest word
                                for (int i = 0; i < numberOfSymbolsNoDupl; ++i)
                                {
                                    for (int j = 0; j < arrayWithoutDuplicates[i].Length; ++j)
                                    {
                                        theLongestWord[i]++;
                                    }
                                }

                                //comparison
                                int maxNumbersTheLongestWord = theLongestWord[0];

                                for (int i = 1; i < numberOfSymbolsNoDupl; ++i)
                                {
                                    if (theLongestWord[i] > maxNumbersTheLongestWord)
                                    {
                                        maxNumbersTheLongestWord = theLongestWord[i];
                                    }
                                }

                                int count = 0;

                                //output of the longest words
                                Console.WriteLine($"\tThe line:{userMainInput}\n");
                                Console.WriteLine($"\tThe words with max number of symbols:\n");

                                for (int i = 0; i < numberOfSymbolsNoDupl; ++i)
                                {
                                    if (theLongestWord[i] == maxNumbersTheLongestWord)
                                    {
                                        count = 0;
                                        for (int j = 0; j < numWorsInArray; j++)
                                        {
                                            if (arrayWithoutDuplicates[i] == lineToWordArr2[j])
                                            {
                                                count++;
                                            }
                                        }

                                        Console.WriteLine($"\tWord {arrayWithoutDuplicates[i]} meet {count} times in the line\n\t");
                                    }
                                }
                            }

                            returnToMainMenu = true;

                            Console.WriteLine("\n\tType anything to returt to main menu");
                            Console.ReadKey();

                            break;

                        //to replace numbers from 0 to 9 with the words
                        case "3":

                            Console.Clear();

                            var string3 = userMainInput;

                            string3 = string3.Replace("0", "zero");
                            string3 = string3.Replace("1", "one");
                            string3 = string3.Replace("2", "two");
                            string3 = string3.Replace("3", "three");
                            string3 = string3.Replace("4", "four");
                            string3 = string3.Replace("5", "five");
                            string3 = string3.Replace("6", "six");
                            string3 = string3.Replace("7", "seven");
                            string3 = string3.Replace("8", "eight ");
                            string3 = string3.Replace("9", "nine");
                            
                            Console.WriteLine($"\tResult of replasement: \n\t{string3}");

                            returnToMainMenu = true;

                            Console.WriteLine("\n\tType anything to returt to main menu");
                            Console.ReadKey();

                            break;

                        //to display interrogative sentences first and then exclamation sentences
                        case "4":

                            Console.Clear();
                            var string4 = userMainInput;

                            string symbolChech = (@"[\?!]");
                            bool lineContainSymbols = Regex.Match(string4, symbolChech).Success;

                            if (lineContainSymbols)
                            {
                                string textWithReplace;
                                textWithReplace = string4.Replace("!", "!.").Replace("?", "?.");

                                string[] textSplit = textWithReplace.Split('.', '\n');
                                int numberOfSentence = textSplit.Length;

                                //to show ? sentences
                                Console.WriteLine("\n\tInterrogative sentences form you line:");

                                for (int i = 0; i < numberOfSentence; i++)
                                {
                                    if (textSplit[i].Contains('?') == true)
                                    {
                                        string trimmed = textSplit[i].Trim();
                                        Console.WriteLine($"{trimmed}");
                                    }
                                }

                                //to show ! sentences
                                Console.WriteLine("\n\tExclamatory sentences form you line:");

                                for (int i = 0; i < numberOfSentence; i++)
                                {
                                    if (textSplit[i].Contains('!') == true)
                                    {
                                        string trimmed = textSplit[i].Trim();
                                        Console.WriteLine($"{trimmed}");
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("\n\tYour line don't contain such sentences");
                            }

                            returnToMainMenu = true;

                            Console.WriteLine("\n\tType anything to returt to main menu");
                            Console.ReadKey();

                            break;

                        //to display only sentences that do not contain commas
                        case "5":

                            Console.Clear();
                            var string5 = userMainInput;

                            string[] textSplit2 = string5.Split('.', '?', '!', '\n');
                            int numberOfSentence2 = textSplit2.Length;

                            int counterForCommas = 0;

                            for (int i = 0; i < numberOfSentence2; i++)
                            {
                                if (textSplit2[i].Contains(',') == true)
                                {
                                    counterForCommas++;
                                }
                            }

                            if ((counterForCommas == numberOfSentence2 - 1) && (textSplit2[0].Contains(',') == true))
                            {
                                Console.WriteLine("\n\tThere are no sentences that do not contain commas.");
                            }

                            else
                            {
                                Console.WriteLine("\n\tSentences that do not contain commas:\n");

                                for (int i = 0; i < numberOfSentence2; i++)
                                {
                                    if (textSplit2[i].Contains(',') == false)
                                    {
                                        Console.WriteLine($"\t{textSplit2[i].Trim()}");
                                    }
                                }
                            }
                           
                            returnToMainMenu = true;

                            Console.WriteLine("\n\tType anything to returt to main menu");
                            Console.ReadKey();

                            break;

                        //to find words starting and ending with the same letter
                        case "6":

                            Console.Clear();

                            var string6 = userMainInput;

                            Console.WriteLine("\nPlease enter the character to search for");

                            string searchInput = Console.ReadLine();                          

                            string[] lineToWordArr = string6.Split(' ', '\t', ',', '.', '!', '?', ':', ';', '\n');

                            Console.WriteLine($"\tWord(s) starting and ending with {searchInput}:");

                            foreach (var item in lineToWordArr)
                            {
                                if ((item.StartsWith(searchInput)) && (item.EndsWith(searchInput)))
                                {
                                    Console.WriteLine($"\t{item} ");
                                }
                                else
                                {
                                    Console.WriteLine("\n\tThere are no such words in the line.");
                                    break;
                                }
                            }
                            
                            returnToMainMenu = true;

                            Console.WriteLine("\n\tType anything to returt to main menu");
                            Console.ReadKey();

                            break;

                        // to repeat line imput
                        case "7":

                            toRepeatLineInput = true;

                            Console.Clear();

                            break;

                        // to close the app
                        case "8":

                            Environment.Exit(0);

                            break;

                        //wrong input
                        default:

                            //red color for warning
                            Console.ForegroundColor = ConsoleColor.DarkRed;                  
                            Console.Clear();

                            //warning message
                            Console.WriteLine("\t You've inputted wrong command. Type anything to be returned to the main menu.");

                            //reset the color
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.ReadKey();

                            returnToMainMenu = true;

                            break;
                    }
                }
            }    
        }
    }   
}