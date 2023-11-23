namespace PC_alkatrészek
{
    internal class Methods
    {

        static List<Read>? products;

        public Methods()
        {
            products = new List<Read>();
        }

        public void ReadIn(string fajlnev)
        {

            var all = File.ReadAllLines(fajlnev);

            string type;
            string name;
            string parameters;
            int price;

            foreach (var line in all)
            {
                var line_parts = line.Trim(';').Split(";");
                type = line_parts[0];
                name = line_parts[1];
                parameters = line_parts[2];
                price = Convert.ToInt32(line_parts[3]);

                products ?.Add(new Read(type, name, parameters, price));
            }
        }

        public void WriteIn()
        {
            string? type;
            string[] types = {"cpu", "motherboard", "ram", "gpu", "hdd", "ssd", "monitor", "mouse", "keyboard"};

            string? name;
            string? parameters;
            int? price;

            Console.WriteLine("Input of parts:");

            do { Console.Write("Enter the type of part (CPU, Motherboard, RAM, GPU, HDD, SSD, Monitor, Mouse, Keyboard): "); type = Console.ReadLine(); } while (!(types.Contains(type?.ToLower())));

            do { Console.Write($"Enter the name of the {type?.ToLower()}: "); name = Console.ReadLine(); } while (!(name == null || name.GetType() == typeof(string))); // Nem működik
        }

    }
}
