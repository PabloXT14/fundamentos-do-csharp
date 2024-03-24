using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte meuByte = 127;

            var text = "Hello, World!";

            Console.WriteLine($"Texto: {text}");
            Console.WriteLine($"Byte: {meuByte}");
        }
    }
}