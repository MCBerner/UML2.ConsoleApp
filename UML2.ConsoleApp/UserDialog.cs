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
        private MenuCatalog _menuCatalog;
        private PizzaStore _pmama;
        
        public UserDialog(MenuCatalog menuCatalog)
        {

            _menuCatalog = menuCatalog;
            _pmama = new PizzaStore();
            
        }

        public Pizza AddNewPizza()
        {
            Pizza pizzaItem = new Pizza();
            _pmama.BigMamaLogo();
           
            Console.WriteLine("***********************");
            Console.WriteLine("*     Tilføj Pizza    *");
            Console.WriteLine("***********************");
            Console.WriteLine();
            string input = "";

            _menuCatalog.ReadAndPrintPizzaList();
            Console.Write("Tilføj pizzanummer: ");
            try
            {
                input = Console.ReadLine();

                pizzaItem.PizzaNumber = Int32.Parse(input);

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            Console.Write("Tilføj navn: ");
            pizzaItem.PizzaName = Console.ReadLine();

            input = "";
            Console.Write("Tilføj pris: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.PizzaPrice = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }


            return pizzaItem;

        }
        public int RemovePizza()
        {
            int pizzaNumber;
            _pmama.BigMamaLogo();

            Console.WriteLine("***********************");
            Console.WriteLine("*      Fjern Pizza    *");
            Console.WriteLine("***********************");
            Console.WriteLine();

            string input = "";
            _menuCatalog.ReadAndPrintPizzaList();
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


        public Pizza UpdatePizza()
        {
            Pizza pizzaItem = new Pizza();
            _pmama.BigMamaLogo();

            Console.WriteLine("***********************");
            Console.WriteLine("*    Opdater Pizza    *");
            Console.WriteLine("***********************");
            Console.WriteLine();
            string input = "";
            _menuCatalog.ReadAndPrintPizzaList();
            Console.Write("Vælg pizza: ");
            try
            {
                input = Console.ReadLine();

                pizzaItem.PizzaNumber = Int32.Parse(input);

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            Console.Write("Tilføj navn: ");
            pizzaItem.PizzaName = Console.ReadLine();

            input = "";
            Console.Write("Tilføj pris: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.PizzaPrice = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }


            return pizzaItem;

        }


        public int SearchPizza()
        {
            
            _pmama.BigMamaLogo();
            int pizzaNummer;

            Console.WriteLine("***********************");
            Console.WriteLine("*       Søg Pizza     *");
            Console.WriteLine("***********************");
            Console.WriteLine();
            string input = "";
            
            Console.Write("Indtast pizza nummer: ");
            try
            {
                input = Console.ReadLine();
                pizzaNummer = Int32.Parse(input);

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }
            return pizzaNummer;
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
                "5. Søg Pizza",
                "6. Test pizza funktionalitet",
            };
            int i = MainMenuChoice(mainMenuList);

            while (proceed) 
            {
                //int testMenuList = Int32.Parse(Console.ReadKey().KeyChar.ToString());
                int testMenuList = i;//MenuChoice = MainMenuChoice(mainMenuList);
                
                Console.Clear();
                PizzaStore pizzaStore = new PizzaStore();
                switch (testMenuList) 
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("BIG MAMA´S PIZZA ønsker dig en dejlig dag");
                        Console.Write("Tryk på en tast for at afslutte");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        _pmama.BigMamaLogo();
                       
                        _menuCatalog.ReadAndPrintPizzaList();                       
                        Console.Write("Tryk på en tast for at fortsætte");
                        Console.ReadKey();
                        Run();
                        break;
                    case 2:
                        
                        try
                        {
                            _menuCatalog.ReadAndPrintPizzaList();
                            Pizza pizza = AddNewPizza();
                            _menuCatalog.AddToList(pizza);
                            _menuCatalog.ReadAndPrintPizzaList();

                            Console.ReadKey();
                            Run();
                        }
                        catch (Exception)
                        {
                            
                            Console.WriteLine($"Pizza´en blev ikke oprettet");
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
                        try
                        {

                            Pizza pizza = UpdatePizza();
                            _menuCatalog.UpdatePizza(pizza);
                            _menuCatalog.ReadAndPrintPizzaList();
                            
                            Console.ReadKey();
                            Run();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Pizza blev ikke fundet.");
                            Console.Write("Indtast igen.");
                            Console.ReadKey();
                           
                        }
                        
                        Console.ReadKey();
                        
                        break;
                    case 5:
                        int pizzaNumberSearch = SearchPizza();
                        _menuCatalog.ReadAndPrintPizza(pizzaNumberSearch);
                        Console.ReadKey();
                        Run();
                        break;
                    case 6:
                        pizzaStore.TestPizzaFunctions();
                        Console.ReadKey();
                        Run();
                        break;
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        Run();
                        break;
                }
            }

           
            Console.ReadKey();
        }
        int MainMenuChoice(List<string> menuItems)
        {
           
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
