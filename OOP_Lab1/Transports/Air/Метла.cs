using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1.Transports.Air
{
    class Метла : AirTransports
    {

        override protected int getAcceliration()
        {
            return 10;
        }
        public Метла(string name) : base(name)
        {

            speed = 50;
        }
    }
}
