using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1.Transports
{
    internal interface ITransport
    {
        public string Name { get; }
        public int Position { get; }
        public int GetPosition(Race race);

    }

    abstract internal class GroundTransports : ITransport
    {

        protected int speed;
        protected int timeToPitStop;
        private string name;
        private int timeToNextPitStop;
        private int pitStopNumber;
        private int durationPitStop;
        private int position;

        public string Name { get => name; }
        public int Position { get => position; }

        protected virtual int getDurationPitStop(int pitStopNumber)
        {
            return 0;
        }

        public int GetPosition(Race race)
        {
            if (timeToNextPitStop == 0 && durationPitStop == 0)
            {
                pitStopNumber++;
                durationPitStop = getDurationPitStop(pitStopNumber);
                timeToNextPitStop = timeToPitStop;
            }
            if (durationPitStop != 0 && timeToNextPitStop == 0)
            {
                durationPitStop--;
                return position;
            }
            timeToNextPitStop--;
            position += speed;
            if (position > race.Distance) position = race.Distance;
            return position;
        }

        public GroundTransports(string name)
        {
            this.name = name;
        }


    }

    abstract internal class AirTransports : ITransport
    {

        protected int speed;
        private string name;
        protected int position;

        public string Name { get => name; }
        public int Position { get => position; }

        protected virtual int getAcceliration()
        {
            return 0;
        }

        public int GetPosition(Race race)
        {
            position += speed;
            speed += getAcceliration();
            if (position > race.Distance) { position = race.Distance; }
            return position;
        }


        public AirTransports(string name)
        {
            this.name = name;
        }

    }

}
