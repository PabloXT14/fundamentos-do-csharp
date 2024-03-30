using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional operator: if else
            int age = 18;
            int ageOfMajority = 21;

            if (age < ageOfMajority)
            {
                Console.WriteLine("Criança/Adolescente");
            }
            else if (age >= ageOfMajority && age < 65)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idoso");
            }

            Console.WriteLine("Finalizou o programa");
        }
    }
}
