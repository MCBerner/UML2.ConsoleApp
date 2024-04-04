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
            Pizza p = new Pizza() { PizzaNumber = 1, PizzaName = "Margherita", PizzaPrice = 69,};
            menuCatalog.AddToList(p);

            p = new Pizza() { PizzaNumber = 2, PizzaName = "Vesuvio", PizzaPrice = 70, };
            menuCatalog.AddToList(p);

            p = new Pizza() { PizzaNumber = 3, PizzaName = "Calzone", PizzaPrice = 75, };
            menuCatalog.AddToList(p);

            p = new Pizza();
            p.PizzaNumber = 4;
            p.PizzaName = "Berner speciale";
            p.PizzaPrice = 145;
            menuCatalog.AddToList(p);
            menuCatalog.ReadAndPrintPizzaList();

            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("*   Tryk en tast for at se bruger menu     *");
            Console.WriteLine("********************************************");
            Console.ReadKey(); 
        }

        public void TestPizzaFunctions()
        {
            PrintMenuCatalog();
            menuCatalog.ReadAndPrintPizzaList();
            Console.WriteLine("");

            Pizza p = new Pizza() { PizzaNumber = 100, PizzaName = "Hawai", PizzaPrice = 69, };
            menuCatalog.AddToList(p);
            menuCatalog.ReadAndPrintPizzaList();
            Console.WriteLine("");
           
            Pizza updatePizza = new Pizza() { PizzaNumber = 100, PizzaName = "Kebab pizza", PizzaPrice = 80, };
            menuCatalog.UpdatePizza(updatePizza);
            menuCatalog.ReadAndPrintPizzaList();
            Console.WriteLine("");
           
            menuCatalog.RemoveFromList(100);
            menuCatalog.ReadAndPrintPizzaList();
            Console.WriteLine("");
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
        }

     

       

    }
}
