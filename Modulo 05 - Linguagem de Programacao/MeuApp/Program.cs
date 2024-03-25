using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 25; // será do tipo int
            var name = "John Doe"; // será do tipo string

            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Idade: {age}");
        }
    }
}