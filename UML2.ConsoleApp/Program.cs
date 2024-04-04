using static System.Formats.Asn1.AsnWriter;

namespace UML2.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzastore = new PizzaStore();
            pizzastore.BigMamaLogo();
            pizzastore.PrintMenuCatalog();
            pizzastore.Run();
            
        }
    }
}
