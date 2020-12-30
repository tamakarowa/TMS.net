using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject
{
    public class Report
    {
        public Report(int numberOfApples, int numberOfPears, int numberOfOranges, int numberOfGrapes, int numberOfPeaches)
        {           
            Product apple;
            apple.price = 1.6;
            apple.id = 1;
            apple.number = numberOfApples;

            Product pear;
            pear.price = 0.89;
            pear.id = 2;
            pear.number = numberOfPears;

            Product orange;
            orange.price = 3.19;
            orange.id = 3;
            orange.number = numberOfOranges;

            Product grape;
            grape.price = 8.50;
            grape.id = 4;
            grape.number = numberOfGrapes;

            Product peach;
            peach.price = 4.55;
            peach.id = 5;
            peach.number = numberOfPeaches;            

            double appleCoast = apple.price * numberOfApples;
            double pearCoast = pear.price * numberOfPears;
            double orangeCoast = orange.price * numberOfOranges;
            double grapeCoast = grape.price * numberOfGrapes;
            double peachCoast = peach.price * numberOfPeaches;

            Console.WriteLine("\t\tResult of Inventarization:");
            
            Console.WriteLine($"\n\t\tName of a product - Apple \n\t\t\tId of a product - {apple.id} \n\t\t\tCoast of 1 apple = {apple.price}, \n\t\t\t{numberOfApples} apple(s) coast {appleCoast}");
            Console.WriteLine($"\n\t\tName of a product - Pear \n\t\t\tId of a product - {pear.id} \n\t\t\tCoast of 1 pear = {pear.price}, \n\t\t\t{numberOfPears} pear(s) coast {pearCoast}");
            Console.WriteLine($"\n\t\tName of a product - Orange \n\t\t\tId of a product - {orange.id} \n\t\t\tCoast of 1 orange = {orange.price}, \n\t\t\t{numberOfOranges} orange(s) coast {orangeCoast}");
            Console.WriteLine($"\n\t\tName of a product - Grape \n\t\t\tId of a product - {grape.id} \n\t\t\tCoast of 1 grape = {grape.price}, \n\t\t\t{numberOfGrapes} grape(s) coast {grapeCoast}");
            Console.WriteLine($"\n\t\tName of a product - Peach \n\t\t\tId of a product - {peach.id} \n\t\t\tCoast of 1 peach = {peach.price}, \n\t\t\t{numberOfPeaches} peach(s) coast {peachCoast}");

            Console.WriteLine("\n\t\tType any key to return to the menu.");

            Console.ReadKey();

        }
        
    }
}
