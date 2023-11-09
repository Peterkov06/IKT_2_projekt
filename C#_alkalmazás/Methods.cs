using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_alkatrészek
{
    internal class Methods
    {

        static List<Read> products;

        static void ReadIn(string fajlnev)
        {
            products = new List<Read>();

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


                products.Add(new Read(type, name, parameters, price));
            }
        }

    }
}
