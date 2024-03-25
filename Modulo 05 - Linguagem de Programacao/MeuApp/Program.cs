using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hello World!";
            string name = "John Doe";

            Console.WriteLine($"Frase: {phrase}");
            Console.WriteLine($"Nome: {name}");
        }
    }
}