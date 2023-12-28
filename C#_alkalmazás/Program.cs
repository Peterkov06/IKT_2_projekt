namespace PC_alkatrészek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods m = new();

            m.ReadIn("products.txt");
            m.TxtWrite("products.txt");
            m.Search();
            m.Statistics();
            m.Sales("products.txt");

            Console.ReadKey();
        }
    }
}