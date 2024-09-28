using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1.Transports.Ground
{
    class СапогиСкороходы : GroundTransports
    {
        override protected int getDurationPitStop(int PitStopNumber)
        {
            return 10;
        }

        public СапогиСкороходы(string name) : base(name)
        {
            speed = 200;
            timeToPitStop = 100;
        }

    }
}
