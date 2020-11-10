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
        static void Main(string[] args)
        {
            string path = @"D:\C#\Projects\TextEditor\NewFile.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
              
            }
            catch (Exception e)
            {
                Console.WriteLine($"File {path} not found. PLease enter the text into the console.");

            }







            Console.ReadLine();
            
        }
    }
}
