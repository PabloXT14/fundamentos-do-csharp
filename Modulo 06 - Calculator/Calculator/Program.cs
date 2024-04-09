using System;

namespace Calculator
{
    class Program
    {
        static int lineWidth = 70;

        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(new string('-', lineWidth));

            Console.WriteLine(CentralizeText("CALCULADORA", lineWidth));

            Console.WriteLine(new string('-', lineWidth));

            // Sum();
            // Subtraction();
            Division();
        }

        static string CentralizeText(string text, int lineWidth)
        {
            int spaceBefore = (lineWidth - text.Length) / 2;
            int spaceAfter = lineWidth - text.Length - spaceBefore;

            string centralizedLine = text.PadLeft(spaceBefore + text.Length).PadRight(spaceAfter);

            return centralizedLine;
        }

        static void Sum()
        {
            Console.Write("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', lineWidth));

            float result = value1 + value2;

            Console.WriteLine($"Resultado da soma: \x1b[33m{result}\x1b[0m");

            Console.ReadKey();
        }

        static void Subtraction()
        {
            Console.Write("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', lineWidth));

            float result = value1 - value2;

            Console.WriteLine($"Resultado da subtração: \x1b[33m{result}\x1b[0m");

            Console.ReadKey();
        }

        static void Division()
        {
            Console.Write("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', lineWidth));

            float result = value1 / value2;

            Console.WriteLine($"Resultado da divisão: \x1b[33m{result}\x1b[0m");

            Console.ReadKey();
        }
    }
}
