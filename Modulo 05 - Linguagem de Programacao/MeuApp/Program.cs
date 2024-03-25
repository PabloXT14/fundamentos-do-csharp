using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? age = 0;
            Console.WriteLine($"Idade 1: {age}");

            age = null;
            Console.WriteLine($"Idade 2: {age}");

            age = 25;
            Console.WriteLine($"Idade 3: {age}");
        }
    }
}