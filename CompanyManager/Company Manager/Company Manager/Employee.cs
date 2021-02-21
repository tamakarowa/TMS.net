using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }
        public enum TypeOfSalary
        {
            NotDefined,
            Hourly,
            Salary,
            Manager,
            Executive
        }

        public TypeOfSalary typeOfsalary = TypeOfSalary.NotDefined;

    }
}
