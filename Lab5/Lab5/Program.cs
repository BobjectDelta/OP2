using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event bDay = Input.InputBDay();
            Event[] events = Event.SortEvents(Input.InputAppointmentArray(bDay));
            Console.WriteLine("List of daily events: \n");
            Event.PrintEvents(events);
            Console.WriteLine("\nTime interval from the last appointment to birthday: ");
            Console.WriteLine(Event.GetTimeLeft(events[Appointment.GetLastAppPosition(events)], bDay));
            Console.ReadKey();
     
        }
    }
}
