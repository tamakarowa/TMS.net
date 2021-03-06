using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AutoPark
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

            Console.WriteLine("\n\tWelcome to the car sharing auto park!");

            FirstMessage();

            int counter = 0;

            var Car1 = new Car();
            Car1.Id = ++counter;
            Car1.yearOfIsuue = 2019;
            Car1.run = 520000;
            Car1.carBrand = Car.CarBrabrand.BMW;
            Car1.carColor = Car.ColorOfCar.black;

            var Car2 = new Car();
            Car2.Id = ++counter;
            Car2.yearOfIsuue = 2021;
            Car2.run = 2000;
            Car2.carBrand = Car.CarBrabrand.VolksWagen;
            Car2.carColor = Car.ColorOfCar.red;

            var Car3 = new Car();
            Car3.Id = ++counter;
            Car3.yearOfIsuue = 2010;
            Car3.run = 360000;
            Car3.carBrand = Car.CarBrabrand.Volvo;
            Car3.carColor = Car.ColorOfCar.grey;

            var Car4 = new Car();
            Car4.Id = ++counter;
            Car4.yearOfIsuue = 1999;
            Car4.run = 520000;
            Car4.carBrand = Car.CarBrabrand.Ford;
            Car4.carColor = Car.ColorOfCar.white;

            var Car5 = new Car();
            Car5.Id = ++counter;
            Car5.yearOfIsuue = 2006;
            Car5.run = 520000;
            Car5.carBrand = Car.CarBrabrand.Ford;
            Car5.carColor = Car.ColorOfCar.white;
            Car5.isCarRented = true;

            var Car6 = new Car();
            Car6.Id = ++counter;
            Car6.yearOfIsuue = 2015;
            Car6.run = 360000;
            Car6.carBrand = Car.CarBrabrand.BMW;
            Car6.carColor = Car.ColorOfCar.white;
            Car6.isCarRented = true;

            List<Car> listOfCars = new List<Car>() { Car1, Car2, Car3, Car4 };

            List<Car> listOfRentedCars = new List<Car>() { Car5, Car6 };

            var notification = new Notifications();
            
            ShowCars(listOfCars);

            bool repeatMenu = true;

            while (repeatMenu)
            {
                repeatMenu = false;

                Console.WriteLine("\n\tPlease select an option you want to do with carsharing park:");

                Console.WriteLine("\n\t1. To rent a car");
                Console.WriteLine("\t2. To stop car rent");
                Console.WriteLine("\t3. To sort cars by they run");

                var userSelectOption = Console.ReadLine();

                switch (userSelectOption)
                {
                    //To rent a car
                    case "1":

                        Console.Clear();

                        Console.WriteLine("Select Id of the car you want to rent:");

                        ShowCars(listOfCars);

                        var carToRent = Console.ReadLine();

                        int carIdToRent = parseId(carToRent, listOfCars);

                        var toRentACar = new Car();

                        int elementId;

                        elementId = 0;

                        //to find element position in list
                        for (int i = 0; i < listOfCars.Count; i++)
                        {
                            if (listOfCars[i].Id == carIdToRent)
                            {
                                elementId = i;
                                break;
                            }
                        }

                        EventLogger.EventLoggerMove();

                        EventLogger.EventLoggerRented();

                        listOfCars[elementId].RentNotification += notification.RentMessage;

                        listOfCars[elementId].Rent();

                        listOfCars[elementId].RentNotification -= notification.RentMessage;

                        listOfCars[elementId].MoveNotification += notification.MoveMessage;

                        listOfCars[elementId].Move();

                        listOfCars[elementId].MoveNotification -= notification.MoveMessage;

                        toRentACar = listOfCars[elementId];

                        listOfRentedCars.Add(toRentACar);

                        listOfCars.RemoveAt(elementId);                       

                        ReturnToMainMenu();

                        repeatMenu = true;

                        break;

                    //To stop car rent
                    case "2":

                        Console.Clear();

                        Console.WriteLine("Select Id of the car you want to return:");

                        ShowCars(listOfRentedCars);

                        var carToReturn = Console.ReadLine();

                        int carIdToReturn = parseId(carToReturn, listOfRentedCars);

                        int elementIdtoReturn = 0;

                        //to find element position in list
                        for (int i = 0; i < listOfRentedCars.Count; i++)
                        {
                            if (listOfRentedCars[i].Id == carIdToReturn)
                            {
                                elementIdtoReturn = i;
                            }
                        }

                        EventLogger.EventLoggerStoped();

                        EventLogger.EventLoggerReturned();

                        listOfRentedCars[elementIdtoReturn].StopNotification += notification.StopMessage;

                        listOfRentedCars[elementIdtoReturn].Stop();

                        listOfRentedCars[elementIdtoReturn].StopNotification -= notification.StopMessage;

                        listOfRentedCars[elementIdtoReturn].ReturnNotification += notification.ReturnMessage;

                        listOfRentedCars[elementIdtoReturn].Return();

                        listOfRentedCars[elementIdtoReturn].ReturnNotification -= notification.ReturnMessage;

                        var toReturnCar = listOfRentedCars[elementIdtoReturn];

                        listOfCars.Add(toReturnCar);

                        listOfRentedCars.RemoveAt(elementIdtoReturn);                        

                        ReturnToMainMenu();

                        repeatMenu = true;

                        break;

                    //To sort cars by they run
                    case "3":

                        listOfCars.Sort();

                        Console.Clear();

                        Console.WriteLine("\n\tList of sorted cars:");

                        for (int i = 0; i < listOfCars.Count; i++)
                        {
                            Car item = listOfCars[i];
                            Console.WriteLine($"\n\tId: {listOfCars[i].Id}. {listOfCars[i].carColor} {listOfCars[i].carBrand}, year of issue {listOfCars[i].yearOfIsuue}, run {listOfCars[i].run}");
                        }

                        ReturnToMainMenu();

                        repeatMenu = true;

                        break;

                    default:

                        Console.WriteLine("\n\tYou've entered unknown operation. \n\tPlease type any key and you will be redirected to the main menu");

                        Console.ReadKey();

                        Console.Clear();

                        repeatMenu = true;

                        break;
                }
            }

            Console.ReadKey();
        }

        //first message for user
        static void FirstMessage()
        {
            Console.WriteLine("\n\tNow we have the foolowing list of cars to rent:");
        }

        //to show all cars
        static void ShowCars(List<Car> listOfCars)
        {
            for (int i = 0; i < listOfCars.Count; i++)
            {
                Console.WriteLine($"\n\tId: {listOfCars[i].Id}. {listOfCars[i].carColor} {listOfCars[i].carBrand}, year of issue {listOfCars[i].yearOfIsuue}, run {listOfCars[i].run}");
            }
        }

        //parse of car id for rent
        static int parseId(string userInterId, List<Car> listOfCars)
        {
            int carId;
            bool checkId;
            bool stopParsing = false;

            do
            {
                checkId = Int32.TryParse(userInterId, out carId);

                for (int i = 0; i < listOfCars.Count; i++)
                {
                    if (listOfCars[i].Id == carId)
                    {
                        stopParsing = true;
                        return carId;
                    }
                }

                Console.Clear();
                Console.WriteLine("Please type the correct car ID!");

                userInterId = Console.ReadLine();
            }

            while (!checkId || !stopParsing);

            Console.Clear();

            return carId;
        }

        //message in switch
        static void ReturnToMainMenu()
        {
            Console.WriteLine("\n\tType anything to return to main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
