using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProductInventoryProject
{
    public class Peach: Product
    {
        public Peach()
        {
            double price;
            int id;
            int number;

            _price = price = double.Parse(ConfigurationManager.AppSettings.Get("peachPrice"));
            _id = id = 5;
            _number = number =0;
        }
    }    
}
