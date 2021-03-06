using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Notifications
    {
        public void MoveMessage()
        {
            Console.WriteLine("\n\tThe movement is started");
        }

        public void RentMessage()
        {
            Console.WriteLine("\n\tThe car is rented");
        }

        public void StopMessage()
        {
            Console.WriteLine("\n\tThe movement is stoped");
        }

        public void ReturnMessage()
        {
            Console.WriteLine("\n\tThe car is returned");
        }
    }
}
