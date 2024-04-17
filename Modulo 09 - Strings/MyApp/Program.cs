using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guid (Global Unique Identifier - Identificador Unico Global) já vem por padrão no System

            var id = Guid.NewGuid();

            // Transformando o Guid em uma string
            // id.ToString();

            // Gerando um Guid com uma string
            // id = new Guid("8f2f5f8f-2f5f-5f8f-8f2f-5f8f8f8f8f8f"); // Ok
            // id = new Guid(""); // Erro

            // Guid todo zerado
            // id = new Guid();

            Console.WriteLine($"id: {id}");
            Console.WriteLine($"id cortado: {id.ToString().Substring(0, 8)}");
        }
    }
}
