using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logic operations
            int x = 12;

            bool between = (x > 25) && (x < 40);
            bool or = (x > 25) || (x < 40);
            bool not = !(x < 25);

            Console.WriteLine($"* x: {x}");
            Console.WriteLine($"* (x > 25) && (x < 40): {between}"); // False
            Console.WriteLine($"* (x > 25) || (x < 40): {or}"); // True
            Console.WriteLine($"* !(x < 25): {not}"); // False
        }
    }
}
