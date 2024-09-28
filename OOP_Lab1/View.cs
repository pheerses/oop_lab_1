using OOP_Lab1.Transports;
using OOP_Lab1.Transports.Air;
using OOP_Lab1.Transports.Ground;

namespace OOP_Lab1
{

    static internal class View
    {
        internal static void ViewRace(Race race)
        {
            var size = 60;
            Console.Clear();
            Console.WriteLine(string.Concat(Enumerable.Repeat("#", size)));
            foreach (var transport in race.Participants)
            {
                var simbol = "-";

                if (transport is AirTransports)
                {
                    simbol = "~";
                }
                if (transport.Position == race.Distance)
                {
                    simbol = " ";
                }
                Console.WriteLine(string.Concat(Enumerable.Repeat(simbol, transport.Position / (race.Distance / size))) + transport.Name);
            };

            Console.WriteLine(string.Concat(Enumerable.Repeat("#", size)));

            Thread.Sleep(300);
        }

        internal static void ReadySetGo()
        {
            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n██████╗░███████╗░█████╗░██████╗░██╗░░░██╗\r\n██╔══██╗██╔════╝██╔══██╗██╔══██╗╚██╗░██╔╝\r\n██████╔╝█████╗░░███████║██║░░██║░╚████╔╝░\r\n██╔══██╗██╔══╝░░██╔══██║██║░░██║░░╚██╔╝░░\r\n██║░░██║███████╗██║░░██║██████╔╝░░░██║░░░\r\n╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n░██████╗███████╗████████╗\r\n██╔════╝██╔════╝╚══██╔══╝\r\n╚█████╗░█████╗░░░░░██║░░░\r\n░╚═══██╗██╔══╝░░░░░██║░░░\r\n██████╔╝███████╗░░░██║░░░\r\n╚═════╝░╚══════╝░░░╚═╝░░░");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\n░██████╗░░█████╗░██╗\r\n██╔════╝░██╔══██╗██║\r\n██║░░██╗░██║░░██║██║\r\n██║░░╚██╗██║░░██║╚═╝\r\n╚██████╔╝╚█████╔╝██╗\r\n░╚═════╝░░╚════╝░╚═╝");
            Thread.Sleep(1000);
            Console.Beep(1000, 500);
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void Results(Race race)
        {
            Console.Clear();
            Console.WriteLine("\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░░░─░█─░░░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░░──░─██──░░░░░░░░░░░░░░░\r\n░░░░░░░░░░░░░░░░──░█─▒██░─░░░░░░░░░░░░░░\r\n░░░░░░░░─░░░░░░░──██──▓██░─░░░─░░░░░░░░░\r\n░░░░░░░─▓─░░░░░──▒█▒───███───▒░─░░░░░░░░\r\n░░░░░░─░█░─░░░░─░██────▓██▒──█░▒──░░░░░░\r\n░░░░░─▒─██──░░░─▒██▒───███▒─██─██──░░░░░\r\n░░░░─░█─██░───░▓░█████████─▓██─░██──░░░░\r\n░░░──██─▒██───██─████████──██▒──▒█▒───░░\r\n░░░─▓█░──██░─▓██──██████───███──░██─░▓─░\r\n░░──██░─▒██░─██▒───████▒───▒███████─██──\r\n░─▒─███████─░██▓───████▒────██████░▒██─░\r\n──█▒▒█████───████▓██████────▓████░─██───\r\n─░█▒─████▓───▓███████████▒░▒████──░██─░░\r\n─██───████▒░▒██████████████████░───██░██\r\n░██░─▒██████████████████████████░░▓█████\r\n░███████████████████████████████████████\r\n█████████───────────────────────████████\r\n──██████──█████████████████████──█████──\r\n█─█████──███████████████████████──████─█\r\n█───────█████████████████████████──────█\r\n████────────────────────────────────████\r\n█─────────────────▄██▄─────────────────█\r\n████████████████████████████████████████\r\n█────██──██████████████████████──██────█\r\n█────██──█░░░░░░░░░░░░░░░░░░░░█──██────█\r\n█▄▄▄▄▄▄▄▄██████████████████████▄▄▄▄▄▄▄▄█\r\n█──────────────────────────────────────█\r\n████████████████████████████████████████\r\n──███████──────────────────────███████──\r\n──███████──────────────────────███████──\r\n──███████──────────────────────███████──\r\n\r\n\r\n");
            Console.WriteLine("Имя\t- Время");
            Console.WriteLine(" \t- ");
            foreach (var transport in race.Rating)
            {
                Console.WriteLine("{0}\t- {1} у.е.", transport.Transport.Name, transport.Time);
            }
            Console.WriteLine();

        }

        internal static Race CreateRace()
        {
            int distance;
            Race.Types type;
            Console.Clear();
            while (true)
            {
                Console.Write("Введите растояние гонки (целое положительное число, оптимально 10000): ");
                var input = Console.ReadLine();
                try {
                    distance = Convert.ToInt32(input);
                    if (distance < 1) {
                        throw new Exception();
                    }
                    break;
                } catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некоректные данные. Попробуйте снова.");
                    Console.ForegroundColor = ConsoleColor.White;
                }  
            }
            Console.Clear();
            while (true)
            {
                Console.Write("Выберите тип гонки \n1 - Только наземные\n2 - Только воздушные\n3 - Все виды\nВаш выбор: ");
                switch (Console.ReadLine()) {
                    case "1":
                        type = Race.Types.OnlyGround;
                        break;
                    case "2":
                        type = Race.Types.OnlyAir;
                        break;
                    case "3":
                        type = Race.Types.All;
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                }
                break;
            }
            return new Race(distance, type);
        }

        internal static List<ITransport> ChooseTransports()
        {
            var transports = new List<ITransport>();

            Console.Clear();
            while (true)
            {
                string ReadName()
                {
                    while (true)
                    {
                        Console.Write("Введите имя (максимум 10 символов): ");
                        var name = Console.ReadLine();
                        
                        if (name is not null)
                        {
                            if (name.Length < 11)
                            {
                                Console.Clear();
                                return name;
                            }
                        }
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некоректные данные. Попробуйте снова.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("Выберите тип транспорта \n1 - Ступа Бабы Яги\n2 - Метла\n3 - Летучий Корабль\n4 - Ковер самолет\n5 - Избушка на курьих ножках\n6 - Карета тыква\n7 - Сапоги скороходы\n8 - Кентавр");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("0 - Запустить гонку");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ваш выбор: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        transports.Add(new СтупаБэйбиЯги(ReadName()));
                        break;
                    case "2":
                        Console.Clear();
                        transports.Add(new Метла(ReadName()));
                        break;
                    case "3":
                        Console.Clear();
                        transports.Add(new ЛетучийКорабль(ReadName()));
                        break;
                    case "4":
                        Console.Clear();
                        transports.Add(new КоверСамолет(ReadName()));
                        break;
                    case "5":
                        Console.Clear();
                        transports.Add(new ИзбушкаНаКурьихНожках(ReadName()));
                        break;
                    case "6":
                        Console.Clear();
                        transports.Add(new КаретаТыква(ReadName()));
                        break;
                    case "7":
                        Console.Clear();
                        transports.Add(new СапогиСкороходы(ReadName()));
                        break;
                    case "8":
                        Console.Clear();
                        transports.Add(new Кентавр(ReadName()));
                        break;
                    case "0":
                        return transports;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            }

        }

        internal static bool Continue()
        { 
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Начать заново? (да/нет): ");
                Console.ForegroundColor = ConsoleColor.White;
                var answer = Console.ReadLine();
                if (answer.ToLower() == "да")
                {
                    return true;
                }
                else if (answer.ToLower() == "нет")
                {
                    return false;
                }
            }


        }
    }

}
