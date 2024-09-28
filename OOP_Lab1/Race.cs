using OOP_Lab1.Transports;

namespace OOP_Lab1
{
    internal class Race
    {

        public enum Types
        {
            OnlyGround,
            OnlyAir,
            All,
        }

        private Types type;
        private int distance;
        private int timeCounter;
        private List<ITransport> participants;
        private List<(int Time, ITransport Transport)> rating;
        public Types Type { get => type; }
        public int Distance { get => distance; }
        public int TimeCounter { get => timeCounter; }
        public List<ITransport> Participants { get => participants; }
        public List<(int Time, ITransport Transport)> Rating { get => rating; }



        public void AddTransports(List<ITransport> transports)
        {
            if (!type.Equals(Types.All))
            {
                foreach (var transport in transports)
                {
                    if (transport is AirTransports && type.Equals(Types.OnlyGround))
                    {
                        throw new Exception(String.Format("Выбранный транспорт не подходит для данного типа гонки: {0}\nДоступны только наземные виды транспорта", transport.Name));
                    }
                    else if (transport is GroundTransports && type.Equals(Types.OnlyAir))
                    {
                        throw new Exception(String.Format("Выбранный транспорт не подходит для данного типа гонки: {0}\nДоступны только воздушные виды транспорта", transport.Name));
                    }
                }
            }
            participants.AddRange(transports);
        }
        public void AddTransports(ITransport transport)
        {
            participants.Add(transport);
        }

        public void StartRace()
        {
            while (participants.Count != rating.Count)
            {
                timeCounter++;
                var newParticipants = new List<ITransport>();
                foreach (ITransport transport in participants)
                {
                    if (transport.Position >= distance)
                    {
                        continue;
                    }
                    var position = transport.GetPosition(this);
                    if (position >= distance)
                    {
                        rating.Add((timeCounter, transport));
                    }
                }
                View.ViewRace(this);
            }

        }
        public Race(int distanse, Types type)
        {
            this.distance = distanse;
            this.type = type;
            this.participants = new List<ITransport>();
            this.rating = new List<(int Time, ITransport Transport)>();
        }
    }
}
