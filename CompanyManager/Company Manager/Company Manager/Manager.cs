using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    class Manager: Employee
    {        
        public bool kpi { get; set; } = true;
        public double constantPayment { get; set; } = 0;
        public double variablPayment { get; set; } = 0;

        public double payment;
        public double Payment
        {
            get
            {
                if (kpi)
                {
                    payment = constantPayment + variablPayment;
                }
                else
                {
                    payment = constantPayment;
                }

                return payment;
            }

            set { value = payment; }
        }
        public Manager()
        {
            typeOfsalary = TypeOfSalary.Manager;
        }
    }
}
