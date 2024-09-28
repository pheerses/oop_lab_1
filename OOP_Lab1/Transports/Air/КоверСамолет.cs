using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1.Transports.Air
{
    class КоверСамолет : AirTransports
    {
        override protected int getAcceliration()
        {
            return (int)(position * 0.1);
        }
        public КоверСамолет(string name) : base(name)
        {
            speed = 50;
        }
    }
}
