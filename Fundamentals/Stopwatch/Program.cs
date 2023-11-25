using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => '10s' = '10 segundos'");
            Console.WriteLine("M = Minuto => '1m' = '1 minuto'");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower().Replace(" ", "");

            bool valid = isValid(data);

            if (valid)
            {
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));
                int multiplier = 1;

                if (type == 'm')
                    multiplier = 60;

                if (time == 0)
                    System.Environment.Exit(0);

                Start(time * multiplier);
            }
            else
            {
                Menu();
            }

        }
        static bool isValid(string input)
        {
            bool valid = input.Contains("s") || input.Contains("m") || input.Contains("0");
            return valid;

        }
    }
}