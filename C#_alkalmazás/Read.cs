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
         *      -CPU --> frequency, socket, cores
         *      -Motherboard --> cpu socket
         *      -RAM --> frequency, size
         *      -GPU --> frequency, memory size
         *      -HDD/SSD --> speed, size
         *      -Monitor --> resolution, Hz
         *      -Mouse --> DPI, vire-less
         *      -Keyboard --> mechanic/membranous
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
