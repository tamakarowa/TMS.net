using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Company_Manager
{
    class Company
    {
        static void Main(string[] args)
        {
            //remove localization
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("US");

            //set background and Foreground color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int counter = 0;

            var employee1 = new Executive();
            employee1.Name = "Makarova Tatsiana";
            employee1.Id = ++counter;
            employee1.numberOfShares = 4000000;
            employee1.incomePerShare = 100;
            employee1.Salary = employee1.Payment;

            var employee2 = new Manager();
            employee2.Name = "Dzianis Shastak";
            employee2.Id = ++counter;
            employee2.kpi = true;
            employee2.constantPayment = 8000;
            employee2.variablPayment = 16000;
            employee2.Salary = employee2.Payment;

            var employee3 = new Manager();
            employee3.Name = "Maria Makarova";
            employee3.Id = ++counter;
            employee3.kpi = false;
            employee3.constantPayment = 8000;
            employee3.variablPayment = 16000;
            employee3.Salary = employee3.Payment;

            var employee4 = new SalariedEmployee();
            employee4.Name = "Orlova Evgeniya";
            employee4.Id = ++counter;
            employee4.payment = 15000;
            employee4.Salary = employee4.payment;

            var employee5 = new HourlyEmployee();
            employee5.Name = "Dmitry Yankov";
            employee5.Id = ++counter;
            employee5.paymentPerHour = 200;
            employee5.numberOfWorkedHours = 40;
            employee5.Salary = employee5.Payment;

            List<Employee> listOfAllEmployees = new List<Employee>() { employee1, employee2, employee3, employee4, employee5 };

            bool repeatMenu = true;
            while (repeatMenu)
            {
                repeatMenu = false;

                FirstMessage();

                ShowEmployees(listOfAllEmployees);

                ActingMenu();

                var userChoseAction = Console.ReadLine();

                switch (userChoseAction)
                {
                    //Hire a new employee
                    case "1":

                        Console.Clear();

                        Console.WriteLine("\n\tPlease select position of new employee:");
                        Console.WriteLine("\n\t1.Hourly Employee");
                        Console.WriteLine("\t2.Salaries Employee");
                        Console.WriteLine("\t3.Manager Employee");
                        Console.WriteLine("\t4.Executive Employee");

                        var newEmployeePosition = Console.ReadLine();

                        switch (newEmployeePosition)
                        {
                            //hourly
                            case "1":

                                var addNewHourlyEmployee = new HourlyEmployee();

                                Console.WriteLine("\tPlease type a name of new employee");

                                addNewHourlyEmployee.Name = Console.ReadLine();

                                addNewHourlyEmployee.Id = ++counter;

                                Console.WriteLine($"\tPlease enter a payment per hour for {addNewHourlyEmployee.Name}");

                                var paymentPerHourUserInput = Console.ReadLine();

                                addNewHourlyEmployee.paymentPerHour = ParsingForDouble(paymentPerHourUserInput);

                                Console.WriteLine($"\tPlease enter number of worked hours for {addNewHourlyEmployee.Name}");

                                var numberOfWorkedHoursUserInput = Console.ReadLine();

                                addNewHourlyEmployee.numberOfWorkedHours = ParsingForDouble(numberOfWorkedHoursUserInput);

                                addNewHourlyEmployee.Salary = addNewHourlyEmployee.Payment;

                                listOfAllEmployees.Add(addNewHourlyEmployee);

                                FirstMessage();

                                ShowEmployees(listOfAllEmployees);

                                ReturnToMainMenu();

                                Console.ReadKey();

                                Console.Clear();

                                repeatMenu = true;

                                break;

                            //salaried
                            case "2":

                                var addNewSalariedEmployee = new SalariedEmployee();

                                Console.WriteLine("\tPlease type a name of new employee");

                                addNewSalariedEmployee.Name = Console.ReadLine();

                                addNewSalariedEmployee.Id = ++counter;

                                Console.WriteLine($"\tPlease enter a salary for {addNewSalariedEmployee.Name}");

                                var salaryUserInput = Console.ReadLine();

                                addNewSalariedEmployee.payment = ParsingForDouble(salaryUserInput);

                                addNewSalariedEmployee.Salary = addNewSalariedEmployee.payment;

                                listOfAllEmployees.Add(addNewSalariedEmployee);

                                FirstMessage();

                                ShowEmployees(listOfAllEmployees);

                                ReturnToMainMenu();

                                Console.ReadKey();

                                Console.Clear();

                                repeatMenu = true;

                                break;

                            //manager
                            case "3":

                                var addNewManagerEmployee = new Manager();

                                Console.WriteLine("\tPlease type a name of new manager");

                                addNewManagerEmployee.Name = Console.ReadLine();

                                addNewManagerEmployee.Id = ++counter;

                                Console.WriteLine($"\tPlease enter a constant payment for {addNewManagerEmployee.Name}");

                                var constantPaymentUserInput = Console.ReadLine();

                                addNewManagerEmployee.constantPayment = ParsingForDouble(constantPaymentUserInput);

                                Console.WriteLine($"\tPlease enter a variabl payment for {addNewManagerEmployee.Name}");

                                var variablPaymentUserInput = Console.ReadLine();

                                addNewManagerEmployee.variablPayment = ParsingForDouble(variablPaymentUserInput);

                                addNewManagerEmployee.Salary = addNewManagerEmployee.Payment;

                                listOfAllEmployees.Add(addNewManagerEmployee);

                                FirstMessage();

                                ShowEmployees(listOfAllEmployees);

                                ReturnToMainMenu();

                                Console.ReadKey();

                                Console.Clear();

                                repeatMenu = true;

                                break;

                            //executer
                            case "4":

                                var addNewExecutiveEmployee = new Executive();

                                Console.WriteLine("\tPlease type a name of new employee");

                                addNewExecutiveEmployee.Name = Console.ReadLine();

                                addNewExecutiveEmployee.Id = ++counter;

                                Console.WriteLine($"\tPlease enter a number of shares for {addNewExecutiveEmployee.Name}");

                                var numberOfSharesUserInput = Console.ReadLine();

                                addNewExecutiveEmployee.numberOfShares = ParsingForDouble(numberOfSharesUserInput);

                                Console.WriteLine($"\tPlease enter income per shares for {addNewExecutiveEmployee.Name}");

                                var incomePerShareUserInput = Console.ReadLine();

                                addNewExecutiveEmployee.incomePerShare = ParsingForDouble(incomePerShareUserInput);

                                addNewExecutiveEmployee.Salary = addNewExecutiveEmployee.Payment;

                                listOfAllEmployees.Add(addNewExecutiveEmployee);

                                FirstMessage();

                                ShowEmployees(listOfAllEmployees);

                                ReturnToMainMenu();

                                Console.ReadKey();

                                Console.Clear();

                                repeatMenu = true;

                                break;

                            default:

                                Console.WriteLine("\n\tYou've entered unknown operation. \n\tPlease type any key and you will be redirected to the main menu");

                                Console.ReadKey();

                                Console.Clear();

                                repeatMenu = true;

                                break;
                        }

                        break;

                    //Fire an employee
                    case "2":

                        Console.WriteLine("Please type Id of employee you vant to fire");

                        var fireEmployee = Console.ReadLine();

                        int idForDel = parseId(fireEmployee, counter);

                        for (int i = 0; i <= listOfAllEmployees.Count; i++)
                        {
                            if (listOfAllEmployees[i].Id == idForDel)
                            {
                                listOfAllEmployees.RemoveAt(i);
                            }
                        }

                        FirstMessage();

                        ShowEmployees(listOfAllEmployees);

                        ReturnToMainMenu();

                        Console.ReadKey();

                        Console.Clear();

                        repeatMenu = true;

                        break;

                    //Promote an employee
                    case "3":

                        Console.WriteLine("Please type Id of employee you vant to promote");

                        var promoteEmployee = Console.ReadLine();

                        int idForPromote = parseId(promoteEmployee, counter);

                        string positionForPromote = null;

                        for (int i = 0; i <= listOfAllEmployees.Count; i++)
                        {
                            if (i == idForPromote)
                            {
                                positionForPromote = listOfAllEmployees[i - 1].typeOfsalary.ToString();
                            }
                        }

                        switch (positionForPromote)
                        {
                            case "Hourly":

                                var HourlyPromoteForSalary = new SalariedEmployee();

                                HourlyPromoteForSalary.Name = listOfAllEmployees[idForPromote - 1].Name;

                                HourlyPromoteForSalary.Id = listOfAllEmployees[idForPromote - 1].Id;

                                Console.WriteLine($"\tPlease enter a salary for {listOfAllEmployees[idForPromote - 1].Name}");

                                var salaryUserInput = Console.ReadLine();

                                HourlyPromoteForSalary.payment = ParsingForDouble(salaryUserInput);

                                HourlyPromoteForSalary.Salary = HourlyPromoteForSalary.payment;

                                listOfAllEmployees.RemoveAt(idForPromote - 1);

                                listOfAllEmployees.Add(HourlyPromoteForSalary);

                                FirstMessage();

                                ShowEmployees(listOfAllEmployees);

                                ReturnToMainMenu();

                                Console.ReadKey();

                                Console.Clear();

                                repeatMenu = true;

                                break;

                            case "Salary":

                                var SalaryPromotedForManager = new Manager();

                                SalaryPromotedForManager.Name = listOfAllEmployees[idForPromote - 1].Name;

                                SalaryPromotedForManager.Id = listOfAllEmployees[idForPromote - 1].Id;

                                Console.WriteLine($"\tPlease enter a constant payment for {SalaryPromotedForManager.Name}");

                                var constantPaymentUserInput = Console.ReadLine();

                                SalaryPromotedForManager.constantPayment = ParsingForDouble(constantPaymentUserInput);

                                Console.WriteLine($"\tPlease enter a variabl payment for {SalaryPromotedForManager.Name}");

                                var variablPaymentUserInput = Console.ReadLine();

                                SalaryPromotedForManager.variablPayment = ParsingForDouble(variablPaymentUserInput);

                                SalaryPromotedForManager.Salary = SalaryPromotedForManager.Payment;

                                listOfAllEmployees.RemoveAt(idForPromote - 1);

                                listOfAllEmployees.Add(SalaryPromotedForManager);

                                FirstMessage();

                                ShowEmployees(listOfAllEmployees);

                                ReturnToMainMenu();

                                Console.ReadKey();

                                Console.Clear();

                                repeatMenu = true;

                                break;

                            case "Manager":

                                var managerPromotedForExecutive = new Executive();

                                managerPromotedForExecutive.Name = listOfAllEmployees[idForPromote - 1].Name;

                                managerPromotedForExecutive.Id = listOfAllEmployees[idForPromote - 1].Id;

                                Console.WriteLine($"\tPlease enter a number of shares for {managerPromotedForExecutive.Name}");

                                var numberOfSharesUserInput = Console.ReadLine();

                                managerPromotedForExecutive.numberOfShares = ParsingForDouble(numberOfSharesUserInput);

                                Console.WriteLine($"\tPlease enter income per shares for {managerPromotedForExecutive.Name}");

                                var incomePerShareUserInput = Console.ReadLine();

                                managerPromotedForExecutive.incomePerShare = ParsingForDouble(incomePerShareUserInput);

                                managerPromotedForExecutive.Salary = managerPromotedForExecutive.Payment;

                                listOfAllEmployees.RemoveAt(idForPromote - 1);

                                listOfAllEmployees.Add(managerPromotedForExecutive);

                                FirstMessage();

                                ShowEmployees(listOfAllEmployees);

                                ReturnToMainMenu();

                                Console.ReadKey();

                                Console.Clear();

                                repeatMenu = true;


                                break;

                            default:
                                break;
                        }

                        break;

                    //Close the app
                    case "4":

                        CloseTheApp();

                        break;

                    //wrong input
                    default:

                        Console.WriteLine("\n\tYou've entered unknown operation. \n\tPlease type any key and you will be redirected to the main menu");

                        Console.ReadKey();

                        Console.Clear();

                        repeatMenu = true;

                        break;
                }
            }
        }

        //first message for user
        static void FirstMessage()
        {
            Console.WriteLine("\n\tThe staff of your company:");
        }

        //menu options
        static void ActingMenu()
        {
            Console.WriteLine("\n\tPlease type the number of an acction you want to do:\n\t1.Hire a new employee\n\t2.Fire an employee\n\t3.Promote an employee\n\t4.Close the app");
        }

        //to show all employees
        static void ShowEmployees(List<Employee> listOfAllEmployees)
        {
            for (int i = 0; i < listOfAllEmployees.Count; i++)
            {
                Console.WriteLine($"\nId: {listOfAllEmployees[i].Id} {listOfAllEmployees[i].Name} \n\tis a {listOfAllEmployees[i].typeOfsalary.ToString()} employee \n\this/her salary per month = {listOfAllEmployees[i].Salary}");
            }
        }

        //to close the app
        static void CloseTheApp()
        {
            Environment.Exit(0);
        }

        //parse of user id for del
        static int parseId(string userInterId, int counter)
        {
            int employeeId;
            bool checkId;

            do
            {
                checkId = Int32.TryParse(userInterId, out employeeId);

                if (!checkId || (employeeId > counter) || (employeeId < 1))
                {
                    Console.Clear();
                    Console.WriteLine("Please type the correct Employee ID!");
                    userInterId = Console.ReadLine();
                }
            }

            while (!checkId || (employeeId > counter) || (employeeId < 1));

            Console.Clear();

            return employeeId;
        }

        //message in switch
        static void ReturnToMainMenu()
        {
            Console.WriteLine("\n\tType anything to return to main menu");
        }

        //parse a position for adding new employee
        static double ParsingForDouble(string userInterLine)
        {
            double doubleAfterParsing;
            bool checkParsing;

            do
            {
                checkParsing = double.TryParse(userInterLine, out doubleAfterParsing);

                if (!checkParsing)
                {
                    Console.Clear();
                    Console.WriteLine("Please type the correct number");
                    userInterLine = Console.ReadLine();
                }
            }

            while (!checkParsing);

            Console.Clear();

            return doubleAfterParsing;
        }
    }
}
