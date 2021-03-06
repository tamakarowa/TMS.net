using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{    
    public class Car: IMovable, IRentabl, IStopable, IReturnabl, IComparable<Car>
    {
        public int yearOfIsuue;

        public double run;

        public bool isCarRented = false;

        public int Id { get; set; }

        public enum ColorOfCar
        {
            notDefined,
            black, 
            white,
            red,
            blue,
            green,
            orange,
            grey,
            purple,
            yellow
        }

        public ColorOfCar carColor = ColorOfCar.notDefined;

        public enum CarBrabrand
        {
            notDefined,
            BMW,
            VolksWagen,
            Opel,
            Skoda,
            Ford,
            Mercedes,
            Subary,
            Volvo,
            Sitroen,
            Reno
        }

        public CarBrabrand carBrand = CarBrabrand.notDefined;

        public delegate void NotificationForMovement();

        public event NotificationForMovement MoveNotification;        

        public void Move()
        {
            MoveNotification();
        }

        public delegate void NotificationForRent();

        public event NotificationForRent RentNotification;

        public void Rent()
        {
            RentNotification();
        }

        public delegate void NotificationForStop();

        public event NotificationForStop StopNotification;

        public void Stop()
        {
            StopNotification();
        }

        public delegate void NotificationForReturn();

        public event NotificationForReturn ReturnNotification;

        public void Return()
        {
            ReturnNotification();
        }

        public int CompareTo(Car item)
        {
            return string.Compare(this.run.ToString(), item.run.ToString());
        }

        public event System.Diagnostics.EntryWrittenEventHandler EntryWritten;
    }
}
