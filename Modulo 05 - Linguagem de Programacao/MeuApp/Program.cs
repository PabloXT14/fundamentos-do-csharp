using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repetition Statement: Do/While
            int value = 0;

            // Conta de 0 a 5
            Console.WriteLine("Contando de 0 a 5:");
            do
            {
                Console.WriteLine(value);
                value++;
            } while (value <= 5);
        }
    }
}
