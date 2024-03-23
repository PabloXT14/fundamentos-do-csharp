using System;
using MeuApp.Test;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // const int IDADE_MINIMA; // Correto, inicia com ZERO
            const int IDADE_MINIMA = 25; // Correto, inicia com 25
            // const var IDADE_MINIMA = 25; // Errado
            // const var IDADE_MINIMA; // Errado

            Console.WriteLine("Hello, World!");
        }
    }
}