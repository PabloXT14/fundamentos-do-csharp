using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // short age = 25; // Correct
            // ushort age = 25; // Correct
            // ushort age = -25; // Error

            // int age = 25; // Correct
            // uint age = 25; // Correct
            // uint age = -25; // Error

            // long age = 25; // Correct
            // ulong age = 25; // Correct
            // ulong age = -25; // Error

            var text = "Hello, World!";

            Console.WriteLine($"Texto: {text}");
        }
    }
}