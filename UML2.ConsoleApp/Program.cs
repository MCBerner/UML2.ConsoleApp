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
            //Console.Write("Du befinder dig i klassen program!");
            Console.ReadKey();
            pizzastore.Run();
            //pizzastore.BigMamaLogo();
            //Console.Write("Du befinder dig IGEN i klassen program!");
            //Console.ReadKey();
            //pizzastore.BigMamaLogo();
            //pizzastore.Run();
            //Console.Write("Det er 3.GANG du befinder i klassen program!");
        }
    }
}
