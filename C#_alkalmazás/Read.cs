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
        string parameters;
        int price;


        public Read(string type, string name, string parameters, int price)
        {
            this.type = type;
            this.name = name;
            this.parameters = parameters;
            this.price = price;
        }

        
    }
}
