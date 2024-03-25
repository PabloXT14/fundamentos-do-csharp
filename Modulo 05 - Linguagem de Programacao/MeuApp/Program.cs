using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            object someValue = "Hello World";
            someValue = 123;
            someValue = 1.000;

            object person = new
            {
                Name = "John Doe",
                Age = 22,
                IsWorking = true,
                Address = "123 Main St",
            };


            Console.WriteLine($"Valor do objeto: {someValue}");
            Console.WriteLine($"Pessoa: {person}");
        }
    }
}