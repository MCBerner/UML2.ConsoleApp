using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2.ConsoleApp
{
    public class PizzaStore
    {
        MenuCatalog menuCatalog;
         

        public PizzaStore()
        {
            menuCatalog = new MenuCatalog();
        }
        public void PrintMenuCatalog() 
        {
            //BigMamaPrint();
            
            Pizza p = new Pizza() { pizzaNumber = 1, pizzaName = "Margherita", pizzaPrice = 69,};
            menuCatalog.AddToList(p);

            p = new Pizza() { pizzaNumber = 2, pizzaName = "Vesuvio", pizzaPrice = 70, };
            menuCatalog.AddToList(p);

            p = new Pizza() { pizzaNumber = 3, pizzaName = "Calzone", pizzaPrice = 75, };
            menuCatalog.AddToList(p);

            p = new Pizza();
            p.pizzaNumber = 4;
            p.pizzaName = "Berner speciale";
            p.pizzaPrice = 145;
            menuCatalog.AddToList(p);
            menuCatalog.ReadAndPrintPizzaList();

            Console.WriteLine("********************************************");
            Console.WriteLine("*   Tryk en tast for at se user dialog     *");
            Console.WriteLine("********************************************");
            Console.ReadKey();
            
        }

        
        public void Run()
        {
            new UserDialog(menuCatalog).Run();
        }
        public void BigMamaLogo() 
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("*           BIG MAMA´S PIZZA               *");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            //menuCatalog.ReadAndPrintPizzaList();

        }
    }
}
