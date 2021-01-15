using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProductInventoryProject
{
    public class Orange: Product
    {
        public Orange()
        {
            double price;
            int id;
            int number;

            _price = price = double.Parse(ConfigurationManager.AppSettings.Get("orangePrice"));
            _id = id =3;
            _number = number =0;
        }
    }
}
