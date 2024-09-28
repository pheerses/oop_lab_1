using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1.Transports.Ground
{
    class ИзбушкаНаКурьихНожках : GroundTransports
    {
        override protected int getDurationPitStop(int PitStopNumber)
        {
            return (int)(PitStopNumber * PitStopNumber * 0.5);
        }

        public ИзбушкаНаКурьихНожках(string name) : base(name)
        {
            speed = 300;
            timeToPitStop = 10;
        }
    }
}
