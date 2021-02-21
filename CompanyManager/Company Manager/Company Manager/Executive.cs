using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Manager
{
    class Executive : Employee
    {
        public double numberOfShares { get; set; } = 0;
        public double incomePerShare { get; set; } = 0;

        public double payment;
        public double Payment
        {
            get
            {
                payment = numberOfShares * incomePerShare;
                return payment;
            }

            set { value = payment; }
        }
        public Executive()
        {
            typeOfsalary = TypeOfSalary.Executive;
        }
    }
}
