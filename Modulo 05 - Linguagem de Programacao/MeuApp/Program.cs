using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional operator: switch
            string weekDay = DateTime.Now.DayOfWeek.ToString();
            // weekDay = "Saturday";

            switch (weekDay)
            {
                case "Tuesday":
                    Console.WriteLine("Hoje é Terça, dia de programação");
                    break;
                case "Thursday":
                    Console.WriteLine("Hoje é Quinta, dia de exercício");
                    break;
                case "Saturday":
                    Console.WriteLine("Hoje é Sábado, dia de descanso");
                    break;
                default:
                    Console.WriteLine("Hoje é um dia normal");
                    break;
            }
        }
    }
}
