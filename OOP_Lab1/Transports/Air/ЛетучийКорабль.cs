using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1.Transports.Air
{
    class ЛетучийКорабль : AirTransports
    {
        override protected int getAcceliration()
        {
            return (int)(position * position * 0.01);
        }
        public ЛетучийКорабль(string name) : base(name)
        {
            speed = 50;
        }
    }
}
