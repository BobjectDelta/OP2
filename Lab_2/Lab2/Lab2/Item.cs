using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Item
    {
        private string _name;
        private string _productionDate;
        private string _expireDate;
        private double _value;
        public Item(string name, string productionDate, string expireDate, double value)
        {
            this._name = name;
            this._value = value;
            this._expireDate = expireDate;
            this._productionDate = productionDate;
        }
        public string GetName()
        {
            return _name;
        }
        public double GetValue()
        {
            return _value;
        }
        public string GetProdDate()
        {
            return _productionDate;
        }
        public string GetExpireDate()
        {
            return _expireDate;
        }

        public string GetAllAtributes()
        {
            return Convert.ToString(_name + " " + _value + " " + _productionDate + " " + _expireDate);
        }
    }
}
