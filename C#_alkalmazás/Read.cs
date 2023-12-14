using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_alkatrészek
{
    internal class Read
    {
        /*
         * type
         * name
         * parameters:
         *      -CPU --> frequency, cores
         *      -Motherboard --> cpu socket, max ram
         *      -RAM --> frequency, size
         *      -GPU --> frequency, memory size
         *      -HDD/SSD --> speed, size
         *      -Monitor --> resolution, Hz
         *      -Mouse --> DPI, vire-less
         *      -Keyboard --> mechanic/membranous, wiht or without numpad
         * price(Ft)
        */

        string type;
        string name;
        string parameter1;
        string parameter2;
        int price;


        public Read(string type, string name, string parameter1, string parameter2, int price)
        {
            this.type = type;
            this.name = name;
            this.parameter1 = parameter1;
            this.parameter2 = parameter2;
            this.price = price;
        }

        public string Type { get => type; }
        public string Name { get => name; }
        public string Parameter1 { get => parameter1; }
        public string Parameter2 { get => parameter2; }
        public int Price { get => price; }
    }
}
