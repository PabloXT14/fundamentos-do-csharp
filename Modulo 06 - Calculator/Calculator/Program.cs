using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(new string('-', 70));


            Console.WriteLine(CentralizeText("CALCULADORA", 70));

            Console.WriteLine(new string('-', 70));

            Console.Write("Digite o primeiro valor: ");

            double value1 = double.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 70));

            Console.WriteLine($"Valor digitado: {value1}");
        }

        static string CentralizeText(string text, int lineWidth)
        {
            int spaceBefore = (lineWidth - text.Length) / 2;
            int spaceAfter = lineWidth - text.Length - spaceBefore;

            string centralizedLine = text.PadLeft(spaceBefore + text.Length).PadRight(spaceAfter);

            return centralizedLine;
        }
    }
}
