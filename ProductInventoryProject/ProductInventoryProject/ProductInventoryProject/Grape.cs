using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProductInventoryProject
{
    public class Grape: Product
    {
        public Grape()
        {
            double price;
            int id;
            int number;

            _price = price = double.Parse(ConfigurationManager.AppSettings.Get("grapePrice"));
            _id = id =4;
            _number = number =0;
        }
    }    
}
