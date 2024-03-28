using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UML2.ConsoleApp
{
    public class UserDialog
    {
        MenuCatalog _menuCatalog;
        PizzaStore _pmama;
        MenuCatalog _pUpdateList;
        public UserDialog(MenuCatalog menuCatalog)
        {
            
            _menuCatalog = menuCatalog;
            _pmama = new PizzaStore();
            _pUpdateList = new MenuCatalog();
        }

        Pizza AddNewPizza()
        {           
            Pizza pizzaItem = new Pizza();
            _pmama.BigMamaLogo();
            
            Console.WriteLine("***********************");
            Console.WriteLine("*     Tilføj Pizza    *");
            Console.WriteLine("***********************");
            Console.WriteLine();
            Console.Write("Tilføj navn: ");
            pizzaItem.pizzaName = Console.ReadLine();

            string input = "";
            Console.Write("Tilføj pris: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.pizzaPrice = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Tilføj pizzanummer: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.pizzaNumber = Int32.Parse(input);
               
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            
            return pizzaItem;
            
        }
        private int RemovePizza()
        {
            int pizzaNumber;
            _pmama.BigMamaLogo();

            Console.WriteLine("***********************");
            Console.WriteLine("*      Fjern Pizza    *");
            Console.WriteLine("***********************");
            Console.WriteLine();
           
            string input = "";            
                      
            Console.Write("Indtast pizzanummer: ");
            try
            {
                input = Console.ReadLine();
                pizzaNumber = Int32.Parse(input);

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            return pizzaNumber;

        }

        public void Run() 
        {

            _pmama.BigMamaLogo();
            bool proceed = true;
            List<string>mainMenuList = new List<string>()
            {
                "0. Afslut",                
                "1. Vis menu",
                "2. Tilføj ny pizza",
                "3. Fjern Pizza",
                "4. Opdater Pizza",
               
            };
            int i = MainMenuChoice(mainMenuList);



            while (proceed) 
            {
                //int testMenuList = Int32.Parse(Console.ReadKey().KeyChar.ToString());
                int testMenuList = i;//MenuChoice = MainMenuChoice(mainMenuList);
                //Console.WriteLine();
               

                Console.Clear();
                //Console.ReadLine();
                PizzaStore pizzaStore = new PizzaStore();
                switch (testMenuList) 
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("BIG MAMA´S PIZZA ønsker dig en dejlig dag");
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 1:

                        
                        Console.Clear();
                        _pmama.BigMamaLogo();
                        Console.WriteLine("Du valgte nummer 1");
                        //PizzaStore.AddNewPizza();
                        _menuCatalog.ReadAndPrintPizzaList();
                        //pizzaStore.PrintMenuCatalog();                       
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        Run();
                        break;
                    case 2:
                        
                        try
                        {
                            Pizza pizza = AddNewPizza();
                            _menuCatalog.AddToList(pizza);
                            _menuCatalog.ReadAndPrintPizzaList();
                           
                            Console.ReadKey();
                            Run();
                        }
                        catch (Exception)
                        {
                            
                            Console.WriteLine($"No pizza created");
                        }                      
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        Run();

                        break;
                    case 3:

                        try 
                        {
                            int pizzaNumber = RemovePizza();
                            _menuCatalog.RemoveFromList(pizzaNumber);
                            _menuCatalog.ReadAndPrintPizzaList();
                            
                            Console.ReadKey();
                            Run();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Pizza blev ikke slettet");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();

                        break;
                    case 4:
                        Console.WriteLine("Du valgte nummer 4");
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        Run();
                        break;
                }
            }

            //Console.Clear();
            Console.WriteLine("Et skridt ad gangen");
            //Run();
            Console.ReadKey();
        }
        int MainMenuChoice(List<string> menuItems)
        {
            //_pmama.BigMamaPrint();
            Console.WriteLine("Indtast dit valg:");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Indtast nummer : ");

            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;

        }
    }
}
