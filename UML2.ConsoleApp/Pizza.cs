using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2.ConsoleApp
{
    public class Pizza
    {
        int _pizzaNumber;
        string _pizzaName;
        double _pizzaPrice;

        public Pizza() 
        {
            _pizzaNumber = pizzaNumber;
            _pizzaName = pizzaName;
            _pizzaPrice = pizzaPrice;
        }

        

        public int pizzaNumber
        {
            get { return _pizzaNumber; }
            set { _pizzaNumber = value; }

        }
        public string pizzaName
        {
            get { return _pizzaName; }
            set { _pizzaName = value; }

        }
        public double pizzaPrice 
        {
            get { return _pizzaPrice; }
            set { _pizzaPrice = value; }
        }
         
        public override string ToString()
        {
            return $"Number: {pizzaNumber}, Name: {pizzaName}, Price: {pizzaPrice}";
        }
    }

}
