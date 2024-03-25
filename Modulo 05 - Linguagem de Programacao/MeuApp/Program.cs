using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1 = 25.8f;
            int number2 = 25;

            number1 = number2; // Conversão implicita
            // number2 = number1; // Erro de conversão implicita

            Console.WriteLine($"number1 = {number1}");
            Console.WriteLine($"number2 = {number2}");
        }
    }
}