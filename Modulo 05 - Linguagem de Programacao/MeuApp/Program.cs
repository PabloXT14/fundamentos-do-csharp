using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char divisorCharacter = '-';
            int divisorLength = 50;

            // Arithmetics operations
            int sum = 25 + 22;
            int subtraction = 25 - 22;
            int multiplication = 25 * 22;
            int division = 22 / 5;

            int x = 2 + 2 * 2;
            int y = (2 + 2) * 2;

            // Assignment operations
            sum += 5;
            subtraction -= 5;
            multiplication *= 5;
            division /= 5;

            Console.WriteLine($"Soma: {sum}");
            Console.WriteLine($"Subtração: {subtraction}");
            Console.WriteLine($"Multiplicação: {multiplication}");
            Console.WriteLine($"Divisão: {division}");

            Console.WriteLine(new string(divisorCharacter, divisorLength));

            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");
        }
    }
}
