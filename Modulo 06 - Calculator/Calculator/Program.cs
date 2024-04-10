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

            Menu();
        }

        static string CentralizeText(string text, int lineWidth)
        {
            int spaceBefore = (lineWidth - text.Length) / 2;
            int spaceAfter = lineWidth - text.Length - spaceBefore;

            string centralizedLine = text.PadLeft(spaceBefore + text.Length).PadRight(spaceAfter);

            return centralizedLine;
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");

            Console.WriteLine(new string('-', lineWidth));

            Console.Write("Selecione uma opção: ");

            short option = short.Parse(Console.ReadLine());

            Console.Clear();

            switch (option)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            Menu();
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

        static void Multiplication()
        {
            Console.Write("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', lineWidth));

            float result = value1 * value2;

            Console.WriteLine($"Resultado da multiplicação: \x1b[33m{result}\x1b[0m");

            Console.ReadKey();
        }
    }
}
