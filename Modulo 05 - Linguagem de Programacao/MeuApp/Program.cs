using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetterName = 'P';
            var secondLetterName = 'a';

            Console.WriteLine($"Primeira letra do nome: {firstLetterName}");
            Console.WriteLine($"Segunda letra do nome: {secondLetterName}");
        }
    }
}