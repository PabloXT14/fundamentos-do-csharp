using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static int lineWidth = 70;

        private static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Especifique o tempo e a unidade de tempo para contagem:");
            Console.WriteLine("Segundos (ex: 10s = 10 segundo)");
            Console.WriteLine("Minutos (ex: 1m = 1 minuto)");
            Console.WriteLine("0 - Sair");

            Console.WriteLine(new string('-', lineWidth));

            Console.Write("Opção: ");
            string data = Console.ReadLine().ToLowerInvariant();

            if (data == "0")
                System.Environment.Exit(0);

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = type == 'm' ? 60 : 1;

            Console.WriteLine(new string('-', lineWidth));

            Start(time * multiplier);

            Menu();
        }

        static void Start(int timeInSeconds)
        {
            int currentTime = 0;

            while (currentTime != timeInSeconds)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); // delay for 1 second 
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(1000);
        }
    }
}
