using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AutoPark
{
    public class EventLogger
    {
        public static void EventLoggerMove()
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("The movement is started", EventLogEntryType.Information, 101, 1);
            }
        }

        public static void EventLoggerRented()
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("The car is rented", EventLogEntryType.Information, 101, 1);
            }
        }

        public static void EventLoggerStoped()
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("The movement is stoped", EventLogEntryType.Information, 101, 1);
            }
        }

        public static void EventLoggerReturned()
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("The car is returned", EventLogEntryType.Information, 101, 1);
            }
        }
    }
}
