using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repetition Statement: While
            int value = 0;

            Console.WriteLine("Conta de 0 a 5");
            while (value <= 5)
            {
                Console.WriteLine(value);
                value++;
            }

            value = 0;
            Console.WriteLine("\nConta de 1 a 6");
            while (value <= 5)
            {
                value++;
                Console.WriteLine(value);
            }

            // Loop Infinito
            // value = 0;
            // while (true)
            // {
            //     Console.WriteLine(value);
            //     value++;
            // }
        }
    }
}
