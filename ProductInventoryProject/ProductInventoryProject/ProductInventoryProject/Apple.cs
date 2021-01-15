using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProductInventoryProject
{
    public class Apple: Product 
    {
        public Apple ()
        {
            double price;
            int id;
            int number;

            _price = price = double.Parse(ConfigurationManager.AppSettings.Get("applePrice"));
            _id = id =1;
            _number = number =0;
        }
    }
}
