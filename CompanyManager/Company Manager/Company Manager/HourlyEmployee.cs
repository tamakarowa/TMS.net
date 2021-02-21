using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    class HourlyEmployee: Employee
    {        
        public double numberOfWorkedHours { get; set; } = 0;
        public double paymentPerHour { get; set; } = 0;

        public double payment;
        public double Payment
        {
            get 
            {
                payment = numberOfWorkedHours * paymentPerHour;
                return payment; 
            }

            set { value = payment; }           
        }        

        public HourlyEmployee()
        {
            typeOfsalary = TypeOfSalary.Hourly;
        }
    }   
}
