using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            int x = 25;
            int y = x;

            Console.WriteLine("Valores iniciais:");
            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");

            x = 32;

            Console.WriteLine(new string('-', 70));

            Console.WriteLine("Valores alterados:");
            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");

            Console.WriteLine(new string('-', 70));

            // Reference Types
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;


            Console.WriteLine("Valores iniciais:");
            Console.WriteLine($"Item 1 (arr): {arr[0]}");
            Console.WriteLine($"Item 1 (arr2): {arr2[0]}");

            arr[0] = "Item alterado";

            Console.WriteLine(new string('-', 70));

            Console.WriteLine("Valores alterados:");
            Console.WriteLine($"Item 1 (arr): {arr[0]}");
            Console.WriteLine($"Item 1 (arr2): {arr2[0]}");
        }
    }
}
