using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(new string('-', 70));

            Console.WriteLine("Calculator");

            Console.WriteLine(new string('-', 70));

            Console.Write("Digite o primeiro valor: ");

            double value1 = double.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 70));

            Console.WriteLine($"Valor digitado: {value1}");
        }
    }
}
