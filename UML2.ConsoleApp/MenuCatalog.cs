using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2.ConsoleApp
{
    
    public class MenuCatalog
    {
        //Instance field
        List<Pizza> _pizzaList;
        
        //Construtor
        //Opretter _pizzaList objectet
        public MenuCatalog()
        {
            _pizzaList = new List<Pizza>();
           
        }

        //Metode 
        //Tilføjer pizza til _pizzaList
        public void AddToList(Pizza p)
        {
            bool pizzaNumberExcist = false;
                
            foreach (Pizza pizzaItem in _pizzaList)
            {
                if (pizzaItem.PizzaNumber == p.PizzaNumber)
                {
                    pizzaNumberExcist = true;
                    break;
                }               
            }
            if (pizzaNumberExcist)
            {
                Console.WriteLine("Pizzanummeret eksistere, vælg venligst et andet.");
                Console.ReadLine();
                
                
            }
            else
            {
                _pizzaList.Add(p);
            }

            
        }

        

        //Metode
        //Metoden printer alle pizzaer i _pizzaList ud når den bliver kaldt
        public void ReadAndPrintPizzaList()
        {
            foreach (Pizza pizzaInList in _pizzaList)
            {
                Console.WriteLine(pizzaInList.ToString());
            }
        }

        public void ReadAndPrintPizza(int pizzaNumber) 
        {
            
            bool pizzaNumberExcist = false;
            Pizza foundPizzaItem = new Pizza();

            foreach (Pizza pizzaItem in _pizzaList)
            {
                if (pizzaItem.PizzaNumber == pizzaNumber)
                {
                    pizzaNumberExcist = true;
                    foundPizzaItem = pizzaItem;
                    break;
                }
            }
            if (pizzaNumberExcist)
            {
                Console.WriteLine(foundPizzaItem);
                Console.ReadLine();
               
            }
            else
            {
                Console.WriteLine("Pizzanummeret eksistere ikke, vælg venligst et andet.");
                ReadAndPrintPizzaList();
                Console.ReadKey();
                
            }
            

        }

        public void RemoveFromList(int pizzaNumber) 
        {
            Pizza item = new Pizza();
            foreach (Pizza pizzaItem in _pizzaList)
            {
                if (pizzaItem.PizzaNumber == pizzaNumber) 
                {
                    item = pizzaItem;
                    break;
                }
                
            }
            _pizzaList.Remove(item);

        }


        public void UpdatePizza(Pizza p) 
        {
           bool pizzaNumberExcist = false;
     
            foreach (Pizza pizzaItem in _pizzaList)
            {
                if (pizzaItem.PizzaNumber == p.PizzaNumber)
                {
                    pizzaNumberExcist = true;
                    pizzaItem.PizzaName = p.PizzaName;
                    pizzaItem.PizzaPrice = p.PizzaPrice;
                    break;
                }
            }
            if (!pizzaNumberExcist)
            {
                Console.WriteLine("Pizzanummeret eksistere ikke, vælg venligst et andet.");
                Console.ReadLine();
            }
        }

    }  
}

   

   
