using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Item
    {
        private string _name;
        private int _amount;
        private double _value;

        public Item(string name, int amount, double value)
        {
            _name = name;
            _amount = amount;
            _value = value;
        }

        public double GetValue()
        {
            return _value;
        }

        public override string ToString()
        {
            return(_name + " " + Convert.ToString(_amount) + " " + Convert.ToString(_value) + "$");
        }
    }
}
