using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProductInventoryProject
{
    public class Pear: Product
    {
        public Pear()
        {
            double price;
            int id;
            int number;

            _price = price = double.Parse(ConfigurationManager.AppSettings.Get("pearPrice"));
            _id = id =2;
            _number = number =0;
        }
    }
}
