using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = Convert.ToInt32("100");

            Console.WriteLine($"Inteiro: {integer}");
        }
    }
}
