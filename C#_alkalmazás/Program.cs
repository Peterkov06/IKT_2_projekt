namespace PC_alkatrészek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods m = new();

            m.ReadIn("proba.txt");
            m.TxtWrite("proba.txt");

            Console.ReadKey();
        }
    }
}