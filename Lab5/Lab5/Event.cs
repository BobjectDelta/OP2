using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Event
    {
        private DateTime _datetime;       
        public Event(DateTime dateTime)
        {
            _datetime = dateTime;
        }

        public DateTime GetDateTime()
        {
            return _datetime;
        }
        public static TimeSpan GetTimeLeft(Event app, Event bday)
        {
            if (app.GetDateTime() >= bday.GetDateTime())
                return (app.GetDateTime() - bday.GetDateTime());
            else
                return (bday.GetDateTime() - app.GetDateTime());
        }

        public static Event[] SortEvents(Event[] events)
        {
            Event @event;
            for (int i = 0; i < events.Length; i++)
            {
                for (int j = 0; j < events.Length - 1; j++)
                {
                    if (events[j].GetDateTime() > events[j + 1].GetDateTime())
                    {
                        @event = events[j];
                        events[j] = events[j + 1];
                        events[j + 1] = @event;
                    }
                }
            }
            return events;
        }

        public static void PrintEvents(Event[] events)
        {
            for (int i = 0; i < events.Length; i++)
            {
                Console.WriteLine(events[i].ToString() + events[i].GetDateTime());
            }
        }
    }
}
