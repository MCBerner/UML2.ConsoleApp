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
            _pizzaNumber = PizzaNumber;
            _pizzaName = PizzaName;
            _pizzaPrice = PizzaPrice;
        }

        public int PizzaNumber
        {
            get { return _pizzaNumber; }
            set { _pizzaNumber = value; }

        }
        public string PizzaName
        {
            get { return _pizzaName; }
            set { _pizzaName = value; }

        }
        public double PizzaPrice 
        {
            get { return _pizzaPrice; }
            set { _pizzaPrice = value; }
        }
         
        public override string ToString()
        {
            return $"Nummer: {PizzaNumber}, Navn: {PizzaName}, Pris: {PizzaPrice}";
        }
    }

}
