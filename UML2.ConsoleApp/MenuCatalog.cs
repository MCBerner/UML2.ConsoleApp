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
            _pizzaList.Add(p);
            
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
        public void RemoveFromList(int pizzaNumber) 
        {
            Pizza item = new Pizza();
            foreach (Pizza pizzaItem in _pizzaList)
            {
                if (pizzaItem.pizzaNumber == pizzaNumber) 
                {
                    item = pizzaItem;
                    break;
                }
                
            }
            _pizzaList.Remove(item);

        }    

    }  
}

   

   
