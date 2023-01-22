using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Appointment : Event
    {
        private string _name;
        private string _place;

        public Appointment(DateTime datetime, string name, string place)
            : base(datetime)
        {
            _name = name;
            _place = place;
        }


        public static int GetLastAppPosition(Event[] events)
        {
            int pos = 0;
            for (int i = 0; i < events.Length; i++)
            {
                if (events[i] is Appointment)
                {
                    pos = i;
                }
            }
            return pos;
        }

        public override string ToString()
        {
            return Convert.ToString(_name + " " + _place + " ");
        }
    }
}
