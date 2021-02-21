using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    class SalariedEmployee : Employee
    {
        public double payment { get; set; } = 0;

        public SalariedEmployee()
        {
            typeOfsalary = TypeOfSalary.Salary;
        }
    }
}
