using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        // Functions or Methods

        static void Main(string[] args)
        {
            var name = ReturnName("John", "Doe");

            Greeting();
            Console.WriteLine(name);
        }

        static void Greeting()
        {
            Console.WriteLine("Hello World!");
        }

        static string ReturnName(string firstName, string lastName, int age = 18)
        {
            return $"{firstName} {lastName} ({age} years old)";
        }
    }
}
