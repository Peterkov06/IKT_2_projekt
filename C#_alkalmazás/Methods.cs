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
            return $"{type!.ToLower()};{name.ToLower()};{parameter1.ToLower()};{parameter2.ToLower()};{price}";
        }

        public void TxtWrite(string fajlnev)
        {
            string response = "";

            do
            {
                string all = WriteIn();
                GenerateHtml(all);

                File.AppendAllText(fajlnev, all + Environment.NewLine);

                Console.ForegroundColor = ConsoleColor.Green;
                do { Console.Write("\nDo you want to bring in another PC part? (Yes/No): "); response = Console.ReadLine() ?? ""; } while (!(response.ToLower() == "yes" || response.ToLower() == "no"));
                Console.ForegroundColor = ConsoleColor.White;

            } while (!(response.ToLower() == "no"));

            ReadIn(fajlnev);
        }

        public void GenerateHtml(string all)
        {
            string[] parts = all.Trim(';').Split(";");
            string type = parts[0];
            string name = parts[1];
            string p1 = parts[2];
            string p2 = parts[3];
            int price = Convert.ToInt32(parts[4]);

            string html = "";

            switch (type)
            {
                case "cpu":
                    html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/cpu.svg\" alt=\"Cpu\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>Frequency: {p1}Mhz</li><li>Cores: {p2}</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
                case "motherboard":
                    html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/motherboard.svg\" alt=\"Motherboard\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>Cpu socket: {p1}</li><li>Maximum amount of ram: {p2}</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
                case "ram":
                    html = html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/ram.svg\" alt=\"Ram\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>Frequency: {p1}Mhz</li><li>Size: {p2} gigabytes</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
                case "gpu":
                    html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/video-card.svg\" alt=\"Video card\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>Frequency: {p1}Mhz</li><li>Memory size: {p2}</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
                case "hdd":
                    html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/hdd.svg\" alt=\"Hdd\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>Speed: {p1}Rpm</li><li>Size: {p2} gigabytes</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
                case "ssd":
                    html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/ssd.svg\" alt=\"Ssd\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>Speed: {p1}Mb/s</li><li>Size: {p2} gigabytes</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
                case "monitor":
                    html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/monitor.svg\" alt=\"Monitor\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>Resolution: {p1}</li><li>Image refresh: {p2}Hz</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
                case "mouse":
                    html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/mouse.svg\" alt=\"Mouse\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>Sensivity: {p1} dpi</li><li>Connection: {p2}</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
                case "keyboard":
                    html = $"<div class=\"card\"><img class=\"card-img-top\" src=\"picuters/keyboard.svg\" alt=\"Keyboard\"><div class=\"card-body\"><h3 class=\"card-title\">{char.ToUpper(name[0]) + name.Substring(1)} {type}</h3><p class=\"card-text\"><ul><li>The kind of switch: {p1}</li><li>Does it have numpad?: {p2}</li><li>Price: {price}Ft</li></ul></p></div></div>";
                    break;
            }

            File.AppendAllText("html.txt", html + Environment.NewLine + Environment.NewLine);

        }

        public void SearchType()
        {
            string type;
            do { type = WriteInErrorHandlingStr("Enter the type of the product you want to search for: "); } while (!(types.Contains(type)));

            for (int i = 0; i < products!.Count; i++)
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

            for (int i = 0; i < products!.Count; i++)
            {
                if (products[i].Name.Contains(name.ToLower()))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\t{products[i].Name} {products[i].Type}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("There aren't such parts in the database.");
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


            for (int i = 0; i < products!.Count; i++)
            {
                if (products[i].Price >= min && products[i].Price <= max)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\t{products[i].Name} {products[i].Type}; {products[i].Price}Ft");
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

            while (!(response.ToLower() == "no"))
            {
                string keyword;
                do { Console.WriteLine("What do you want to search for? Write down the keyword!"); Console.Write("(type/name/(between) prices): "); keyword = Console.ReadLine() ?? ""; } while (!(keyword == "type" || keyword == "name" || keyword == "price" || keyword == "prices"));

                if (keyword == "type") { SearchType(); }
                if (keyword == "name") { SearchName(); }
                if (keyword == "price" || keyword == "prices") { SearchPrice(); }

                Console.ForegroundColor = ConsoleColor.Blue;
                do { Console.Write("Do you want to search among the parts? (Yes/No): "); response = Console.ReadLine() ?? ""; } while (!(response.ToLower() == "yes" || response.ToLower() == "no"));
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        public void Statistics()
        {
            string response;

            Console.ForegroundColor = ConsoleColor.Magenta;
            do { Console.Write("Do you want to see the statistics? (Yes/No): "); response = Console.ReadLine() ?? ""; } while (!(response.ToLower() == "yes" || response.ToLower() == "no"));
            Console.ForegroundColor = ConsoleColor.White;

            if (!(response.ToLower() == "no"))
            {
                double length = products!.Count();
                double sum;

                Console.ForegroundColor = ConsoleColor.Cyan;

                for (int i = 0; i < types.Length; i++)
                {
                    sum = products!.Where(x => x.Type == types[i]).Count();

                    Console.WriteLine($"\t{types[i]}s are {Math.Round((sum / length) * 100.0, 2)}% of the products.");

                }
               
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        public void RewriteFile_Sales(string fajlnev, string keyword, int percentage)
        {
            //Open file to rewrite
            using (var input = File.OpenText(fajlnev))
            using (var output = new StreamWriter("output.txt"))
            {
                string line;

                while (null != (line = input.ReadLine()!))
                {
                    string[] parts = line.Trim(';').Trim('\n').Split(";");
                    string type = parts[0];
                    int price = Convert.ToInt32(parts[parts.Length - 1]);

                    if (keyword.ToLower() == "all")
                    {   
                            price -= (price / 100) * percentage;
                    }
                    else
                    {
                        if (type == keyword.ToLower())
                        {
                            price -= (price / 100) * percentage;
                        }
                       
                    }
                    output.WriteLine($"{type};{parts[1]};{parts[2]};{parts[3]};{price}");
                }
            }
            File.Replace("output.txt", fajlnev, null);
        }

        public void Sales(string fajlnev)
        {
            string response;

            Console.ForegroundColor = ConsoleColor.Blue;
            do { Console.Write("Do you want to put products on sale? (Yes/No): "); response = Console.ReadLine() ?? ""; } while (!(response.ToLower() == "yes" || response.ToLower() == "no"));
            Console.ForegroundColor = ConsoleColor.White;

            while (!(response.ToLower() == "no"))
            {
                string keyword;
                int percentage = 0;

                do { Console.WriteLine("Which products do you want to put on sale?"); Console.Write("Write down the type of the product, or if you want to put everything on sale, write 'all': "); keyword = Console.ReadLine() ?? ""; } while (!(types.Contains(keyword.ToLower()) || keyword.ToLower() == "all"));

                do { percentage = Convert.ToInt32(WriteInErrorHandlingInt("Write down the percentage of the sale: ")); } while (!(percentage > 0 || percentage < 100));

                RewriteFile_Sales(fajlnev, keyword, percentage);
                ReadIn(fajlnev);                

                Console.ForegroundColor = ConsoleColor.Blue;
                do { Console.Write("Do you want to put other products on sale? (Yes/No): "); response = Console.ReadLine() ?? ""; } while (!(response.ToLower() == "yes" || response.ToLower() == "no"));
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

    }
}
