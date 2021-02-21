using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    class Program
    {   
        public static void Main(string[] args)
        {
            //remove localization
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("US");

            //set background and Foreground color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            var grannyDadSide = new Mother();
            grannyDadSide.Name = "Maria";
            grannyDadSide.IsWoman = true; 
            grannyDadSide.IsMother = true;

            var grandadDadSide = new Father();
            grandadDadSide.Name = "Victor";
            grandadDadSide.IsWoman = false;
            grandadDadSide.IsFather = true;

            var fatherPerson = Person.CreateChildren(grannyDadSide, grannyDadSide);
            Father father = new Father(fatherPerson);
            father.Name = "Valery";
            father.IsWoman = false;
            father.IsFather = true;

            var grannyMomSide = new Mother();
            grannyMomSide.Name = "Tomara";
            grannyMomSide.IsWoman = true;
            grannyMomSide.IsMother = true;

            var grandadMomSide = new Father();
            grandadMomSide.Name = "Grigory";
            grandadMomSide.IsWoman = false;
            grandadMomSide.IsFather = true;

            var motherPerson = (Mother)Person.CreateChildren(grannyMomSide, grandadMomSide);
            Mother mother = (Mother)motherPerson;
            mother.Name = "Elena";
            mother.IsWoman = true;
            mother.IsMother = true;

            var me = Person.CreateChildren(mother, father);
            me.Name = "Tanya";
            me.IsWoman = true;  

            var sister = Person.CreateChildren(mother, father);
            sister.Name = "Maria";
            sister.IsWoman = true;
    








            Console.WriteLine($"{grannyDadSide.Id.ToString()}, {me.Id.ToString()}");


            Console.ReadKey();
        }
    }
}
