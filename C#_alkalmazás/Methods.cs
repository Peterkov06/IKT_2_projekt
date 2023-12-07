using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string parameter;
            int price;

            foreach (var line in all)
            {
                var line_parts = line.Trim(';').Split(";");
                type = line_parts[0];
                name = line_parts[1];
                parameter = line_parts[2];
                price = Convert.ToInt32(line_parts[3]);

                products ?.Add(new Read(type, name, parameter, price));
            }
        }
        public string WriteInErrorHandling(string output1, string output2)
        {
            string p1;
            string p2;

            do { Console.Write($"\t{output1}"); p1 = Console.ReadLine() ?? ""; } while (p1 == "");
            do { Console.Write($"\t{output2}"); p2 = Console.ReadLine() ?? ""; } while (p2 == "");

            return p1 + "," + p2;
        }
        public string WriteIn()
        {
            string type;
            string[] types = {"cpu", "motherboard", "ram", "gpu", "hdd", "ssd", "monitor", "mouse", "keyboard"};

            string name;
            string parameters = "";
            int price;

            Console.WriteLine("Input of parts:");

            //Type
            do { Console.Write("Enter the type of part (CPU, Motherboard, RAM, GPU, HDD, SSD, Monitor, Mouse, Keyboard): "); type = Console.ReadLine() ?? ""; } while (!(types.Contains(type?.ToLower())));

            //Name
            do { Console.Write($"Enter the name of the {type?.ToLower()}: "); name = Console.ReadLine() ?? ""; } while (name == "" || name.GetType() != typeof(string));

            //Parameters
            string p1;
            string p2;
            Console.WriteLine($"Enter the parameters of {name} {type}: ");

            switch (type?.ToLower())
            {
                case "cpu":
                    parameters = WriteInErrorHandling("Enter the frequency of the CPU in Mhz: ", "Enter the number of the CPU cores: ");
                    break;

                case "motherboard":
                    parameters = WriteInErrorHandling("Enter the type of the CPU socket: ", "Enter the maximum amount of RAM in gigabytes, that the motherboard can handle: ");
                    break;

                case "ram":
                    parameters = WriteInErrorHandling("Enter the frequency of the RAM in Mhz: ", "Enter the size of the RAM in gigabytes: ");
                    break;

                case "gpu":
                    parameters = WriteInErrorHandling("Enter the frequency of the GPU in Mhz: ", "Enter the size of the GPU's ram in gigabytes: ");
                    break;

                case "hdd":
                    parameters = WriteInErrorHandling("Enter the speed of the HDD in RPM: ", "Enter the storage capacity of the HDD: ");
                    break;

                case "ssd":
                    parameters = WriteInErrorHandling("Enter the speed of the SSD in MB/s: ", "Enter the storage capacity of the SSD: ");
                    break;

                case "monitor":
                    parameters = WriteInErrorHandling("Enter the resolution of the monitor: ", "Enter the refresh rate of the monitor in Hz: ");
                    break;

                case "mouse":
                    parameters = WriteInErrorHandling("Enter the dpi size of the mouse: ", "Enter the connection type of the mouse (f.e.: wire, wireless): ");
                    break;

                case "keyboard":
                    do { Console.Write("\tEnter the type of the keyboard (mechanic/membranous): "); p1 = Console.ReadLine() ?? ""; } while (!(p1.ToLower() == "mechanic" || p1.ToLower() == "membranous"));
                    do { Console.Write("\tDoes it have numpad(Yes/No)? :  "); p2 = Console.ReadLine() ?? ""; } while (!(p2.ToLower() == "yes" || p2.ToLower() == "no"));
                    parameters = $"{p1},{p2}";
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
            return $"{type};{name};{parameters};{price};";
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
                Console.ForegroundColor= ConsoleColor.White;

            } while (!(response.ToLower() == "no"));

            ReadIn(fajlnev);
        }

    }
}
