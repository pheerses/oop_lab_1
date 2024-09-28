namespace OOP_Lab1
{

    internal class Program
    {
        static int Main() {
            do
            {
                var race = View.CreateRace();

                var transports = View.ChooseTransports();

                race.AddTransports(transports);

                View.ReadySetGo();

                race.StartRace();

                View.Results(race);
            } 
            while (View.Continue());

            return 0;
        }
    }
}
