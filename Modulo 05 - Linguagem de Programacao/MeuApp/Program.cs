using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro;

            Console.WriteLine($"Inteiro = {inteiro}");
            Console.WriteLine($"Inteiro Sem Sinal = {inteiroSemSinal}");
        }
    }
}