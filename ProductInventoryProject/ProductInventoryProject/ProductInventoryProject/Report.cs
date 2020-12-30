using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject
{
    public class Report
    {
        public Report(int numberOfApples, int numberOfPears, int numberOfOrenges, int numberOfGrapes, int numberOfPeaches)
        {         
            var applesForReport = new Apple();
            var pearsForReport = new Pear();
            var orengesForReport = new Orange();
            var grapesForreport = new Grape();
            var peachesForReport = new Peach();           

            double applePrice = applesForReport._price;
            double pearPrice = pearsForReport._price;
            double orangePrice = orengesForReport._price;
            double grapePrice = grapesForreport._price;
            double peachePrice = peachesForReport._price;

            double appleId = applesForReport._id;
            double pearId = pearsForReport._id;
            double orangeId = orengesForReport._id;
            double grapeId = grapesForreport._id;
            double peacheId = peachesForReport._id;

            double appleCoast = applePrice * numberOfApples;
            double pearCoast = pearPrice * numberOfPears;
            double orangeCoast = orangePrice * numberOfOrenges;
            double grapeCoast = grapePrice * numberOfGrapes;
            double peachCoast = peachePrice * numberOfPeaches;

            Console.WriteLine("\t\tResult of Inventarization:");
            
            Console.WriteLine($"\n\t\tName of a product - Apple \n\t\t\tId of a product - {appleId} \n\t\t\tCoast of 1 apple = {applePrice}, \n\t\t\t{numberOfApples} apple(s) coast {appleCoast}");
            Console.WriteLine($"\n\t\tName of a product - Pear \n\t\t\tId of a product - {pearId} \n\t\t\tCoast of 1 pear = {pearPrice}, \n\t\t\t{numberOfPears} pear(s) coast {pearCoast}");
            Console.WriteLine($"\n\t\tName of a product - Orange \n\t\t\tId of a product - {orangeId} \n\t\t\tCoast of 1 orange = {orangePrice}, \n\t\t\t{numberOfOrenges} orange(s) coast {orangeCoast}");
            Console.WriteLine($"\n\t\tName of a product - Grape \n\t\t\tId of a product - {grapeId} \n\t\t\tCoast of 1 grape = {grapePrice}, \n\t\t\t{numberOfGrapes} grape(s) coast {grapeCoast}");
            Console.WriteLine($"\n\t\tName of a product - Peach \n\t\t\tId of a product - {peacheId} \n\t\t\tCoast of 1 peach = {peachePrice}, \n\t\t\t{numberOfPeaches} peach(s) coast {peachCoast}");

            Console.WriteLine("\n\t\tType any key to return to the menu.");

            Console.ReadKey();

        }
        
    }
}
