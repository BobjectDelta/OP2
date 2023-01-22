using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5;

namespace Lab5
{
    internal class Input
    {
        public static Event InputBDay()
        {
            string name;
            string place;
            int age;
            DateTime bday;
            Console.WriteLine("Enter name, place, age and datetime of birthday: ");
            name = Console.ReadLine();
            place = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            string datetime = Console.ReadLine();

            while (!DateTime.TryParse(datetime, out bday))
            {
                Console.WriteLine("Date error. Try again: ");
                datetime = Console.ReadLine();
            }
            Event day = new BDay(bday, name, age, place);
            return day;
        }

        public static Event[] InputAppointmentArray(Event bDay)
        {
            string datestr;
            DateTime dateTime;
            string name;
            string place;
            bool isParsed = false;
            Console.WriteLine("Enter wanted number of appointments: ");
            int numOfApp = Convert.ToInt32(Console.ReadLine());
            Event[] appointments = new Event[numOfApp + 1];
            appointments[0] = bDay;

            for (int i = 1; i < appointments.Length; i++)
            {
                Console.WriteLine("Enter name, place and datetime of {0} appointment (same date as birthday): ", i);
                name = Console.ReadLine();
                place = Console.ReadLine();
                datestr = Console.ReadLine();
                isParsed = DateTime.TryParse(datestr, out dateTime);
                while (!DateTime.TryParse(datestr, out dateTime) || dateTime.Date != bDay.GetDateTime().Date)
                {
                    Console.WriteLine("Date error. Try again:");
                    datestr = Console.ReadLine();
                }

                appointments[i] = new Appointment(dateTime, name, place);
            }

            return appointments;
        }
    }
}
