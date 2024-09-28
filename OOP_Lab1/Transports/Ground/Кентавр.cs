using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1.Transports.Ground
{
    class Кентавр : GroundTransports
    {
        override protected int getDurationPitStop(int PitStopNumber)
        {
            return PitStopNumber;
        }
        public Кентавр(string name) : base(name)
        {
            speed = 150;
            timeToPitStop = 10000;
        }

    }
}
