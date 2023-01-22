using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class BDay : Event
    {
        private string _name;
        private int _age;
        private string _place;

        public BDay(DateTime datetime, string name, int age, string place)
            : base(datetime)
        {
            _name = name;
            _age = age;
            _place = place;
        }

        

        public override string ToString()
        {
            return Convert.ToString(_name + " " + _age + " " + _place + " ");
        }
    }
}
