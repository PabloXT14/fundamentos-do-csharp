using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repetition Statement: For

            // Conta de 0 a 5
            Console.WriteLine("Contando de 0 a 5");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // Conta de 1 a 5
            Console.WriteLine("\nContando de 1 a 5");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // Conta de 0 a 4
            Console.WriteLine("\nContando de 0 a 4");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Contando de 5 a 0
            Console.WriteLine("\nContando de 5 a 0");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
