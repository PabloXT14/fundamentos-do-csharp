using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = int.Parse("100");

            Console.WriteLine($"Inteiro: {inteiro}");
        }
    }
}