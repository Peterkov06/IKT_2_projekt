using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PC_alkatrészek
{
    internal class Methods
    {

        static List<Read>? products;
        string[] types = { "cpu", "motherboard", "ram", "gpu", "hdd", "ssd", "monitor", "mouse", "keyboard" };
        public Methods()
        {
            products = new List<Read>();
        }

        public void ReadIn(string fajlnev)
        {

            var all = File.ReadAllLines(fajlnev);

            string type;
            string name;
            string parameter1;
            string parameter2;
            int price;

            foreach (var line in all)
            {
                var line_parts = line.Trim(';').Trim('\n').Split(";");
                type = line_parts[0];
                name = line_parts[1];
                parameter1 = line_parts[2];
                parameter2 = line_parts[3];
                price = Convert.ToInt32(line_parts[4]);

                products?.Add(new Read(type, name, parameter1, parameter2, price));
            }
        }
        public string WriteInErrorHandlingStr(string output)
        {
            string p;

            do { Console.Write($"\t{output}"); p = Console.ReadLine() ?? ""; } while (p == "");

            return p;
        }

        public string WriteInErrorHandlingInt(string output)
        {
            string p;
            bool number;

            do
            {
                int x;
                Console.Write($"\t {output}");
                p = Console.ReadLine() ?? "";
                number = int.TryParse(p, out x);
            } while (p == "" || number == false);

            return p;
        }
        public string WriteIn()
        {
            string type;

            string name;
            string parameter1 = "";
            string parameter2 = "";
            int price;

            Console.WriteLine("Input of parts:");

            //Type
            do { Console.Write("Enter the type of part (CPU, Motherboard, RAM, GPU, HDD, SSD, Monitor, Mouse, Keyboard): "); type = Console.ReadLine() ?? ""; } while (!(types.Contains(type?.ToLower())));

            //Name
            do { Console.Write($"Enter the name of the {type?.ToLower()}: "); name = Console.ReadLine() ?? ""; } while (name == "" || name.GetType() != typeof(string));

            //Parameters
            Console.WriteLine($"Enter the parameters of {name} {type}: ");

            switch (type?.ToLower())
            {
                case "cpu":
                    parameter1 = WriteInErrorHandlingInt("Enter the frequency of the CPU (in Mhz): ");
                    parameter2 = WriteInErrorHandlingInt("Enter the number of the CPU cores: ");
                    break;

                case "motherboard":
                    parameter1 = WriteInErrorHandlingStr("Enter the type of the CPU socket: ");
                    parameter2 = WriteInErrorHandlingInt("Enter the maximum amount of RAM, that the motherboard can handle (in gigabytes): ");
                    break;

                case "ram":
                    parameter1 = WriteInErrorHandlingInt("Enter the frequency of the RAM in Mhz: ");
                    parameter2 = WriteInErrorHandlingInt("Enter the size of the RAM in gigabytes: ");
                    break;

                case "gpu":
                    parameter1 = WriteInErrorHandlingInt("Enter the frequency of the GPU (in Mhz): ");
                    parameter2 = WriteInErrorHandlingInt("Enter the size of the GPU's ram (in gigabytes): ");
                    break;

                case "hdd":
                    parameter1 = WriteInErrorHandlingInt("Enter the speed of the HDD in RPM: ");
                    parameter2 = WriteInErrorHandlingInt("Enter the storage capacity of the HDD (in gigabytes): ");
                    break;

                case "ssd":
                    parameter1 = WriteInErrorHandlingInt("Enter the speed of the SSD in MB/s: ");
                    parameter2 = WriteInErrorHandlingInt("Enter the storage capacity of the SSD (in gigabytes): ");
                    break;

                case "monitor":
                    parameter1 = WriteInErrorHandlingStr("Enter the resolution of the monitor (f.e.: 1920x1080): ");
                    parameter2 = WriteInErrorHandlingInt("Enter the refresh rate of the monitor in Hz: ");
                    break;

                case "mouse":
                    parameter1 = WriteInErrorHandlingInt("Enter the dpi size of the mouse: ");
                    parameter2 = WriteInErrorHandlingStr("Enter the connection type of the mouse (f.e.: wire, wireless, bluetooth, etc..): ");
                    break;

                case "keyboard":
                    do { Console.Write("\tEnter the type of the keyboard (mechanic/membranous): "); parameter1 = Console.ReadLine() ?? ""; } while (!(parameter1.ToLower() == "mechanic" || parameter1.ToLower() == "membranous"));
                    do { Console.Write("\tDoes it have numpad(Yes/No)? :  "); parameter2 = Console.ReadLine() ?? ""; } while (!(parameter2.ToLower() == "yes" || parameter2.ToLower() == "no"));
                    break;
            }

            //Price
            string strPrice;
            bool number;
            do
            {
                Console.Write($"Enter the price of the {type}: ");
                strPrice = Console.ReadLine() ?? "";
                number = int.TryParse(strPrice, out price);
            } while (strPrice == "" || number == false);

            //Return all things
            return $"{type.ToLower()};{name.ToLower()};{parameter1.ToLower()};{parameter2.ToLower()};{price}";
        }

        public void TxtWrite(string fajlnev)
        {
            string response = "";

            do
            {
                string all = WriteIn();

                File.AppendAllText(fajlnev, all + Environment.NewLine);

                Console.ForegroundColor = ConsoleColor.Green;
                do { Console.Write("\nDo you want to bring in another PC part? (Yes/No): "); response = Console.ReadLine() ?? ""; } while (!(response.ToLower() == "yes" || response.ToLower() == "no"));
                Console.ForegroundColor = ConsoleColor.White;

            } while (!(response.ToLower() == "no"));

            ReadIn(fajlnev);
        }

        public void SearchType()
        {
            string type;
            do { type = WriteInErrorHandlingStr("Enter the type of the product you want to search for: "); } while (!(types.Contains(type)));

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Type == type)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\t{products[i].Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public void SearchName()
        {
            string name = WriteInErrorHandlingStr("Enter the name of the product you want to search for: ");

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name.Contains(name.ToLower()))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{products[i].Name} {products[i].Type}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }

        public void SearchPrice()
        {
            int min;
            string min_;
            int max;
            string max_;
            bool number;

            do
            {
                Console.Write($"\tEnter the minimum price: ");
                min_ = Console.ReadLine() ?? "";
                number = int.TryParse(min_, out min);
            } while (min_ == "" || number == false);
            
            do
            {
                Console.Write($"\tEnter the maximum price: ");
                max_ = Console.ReadLine() ?? "";
                number = int.TryParse(max_, out max);
            } while (max_ == "" || number == false);


            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price >= min && products[i].Price <= max)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{products[i].Name} {products[i].Type}; {products[i].Price}Ft");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }
        public void Search()
        {
            string response;

            Console.ForegroundColor = ConsoleColor.Blue;
            do { Console.Write("Do you want to search among the parts? (Yes/No): "); response = Console.ReadLine() ?? ""; } while (!(response.ToLower() == "yes" || response.ToLower() == "no"));
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                string keyword;
                do { Console.WriteLine("What do you want to search for? Write down the keyword!"); Console.Write("(type/name/(between) prices): "); keyword = Console.ReadLine() ?? ""; } while (!(keyword == "type" || keyword == "name" || keyword == "price" || keyword == "prices"));

                if (keyword == "type") { SearchType(); }
                if (keyword == "name") { SearchName(); }
                if (keyword == "price" || keyword == "prices") { SearchPrice(); }

                Console.ForegroundColor = ConsoleColor.Blue;
                do { Console.Write("Do you want to search among the parts? (Yes/No): "); response = Console.ReadLine() ?? ""; } while (!(response.ToLower() == "yes" || response.ToLower() == "no"));
                Console.ForegroundColor = ConsoleColor.White;

            } while (!(response.ToLower() == "no"));

        }

    }
}
