using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float salarioMensal = 2.500f;
            double salarioSemestral = 15.000;
            decimal salarioAnual = 30.000m;

            var salario = 1.000; // padrão de valor flutuante é o double

            var text = "Hello, World!";

            Console.WriteLine($"Texto: {text}");
        }
    }
}