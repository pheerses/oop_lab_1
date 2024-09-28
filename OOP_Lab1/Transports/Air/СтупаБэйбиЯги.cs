using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1.Transports.Air
{
    class СтупаБэйбиЯги : AirTransports
    {
        override protected int getAcceliration()
        {
            return 10000 / position;
        }
        public СтупаБэйбиЯги(string name) : base(name)
        {
            speed = 100;
        }

    }
}
