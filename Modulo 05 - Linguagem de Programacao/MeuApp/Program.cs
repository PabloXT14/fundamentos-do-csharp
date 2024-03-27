using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 100;
            float real = 25.8f;

            // real = integer; // Conversão implícita
            // integer = (int)real; // Conversão explícita
            // string realValueInString = real.ToString(); // ToString
            // integer = int.Parse("255"); // Parse
            integer = Convert.ToInt32(real); // Convert

            // Console.WriteLine(realValueInString);
            Console.WriteLine(integer);
            Console.WriteLine(Convert.ToBoolean(0));
            Console.WriteLine(Convert.ToBoolean(1));
        }
    }
}
