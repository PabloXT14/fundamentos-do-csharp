using System;

namespace TextEditor
{
    class Program
    {
        static int lineWidth = 70;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: New(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {

        }

        static void New()
        {
            Console.Clear();

            Console.WriteLine("Digite o seu texto abaixo (ESC para sair)");
            Console.WriteLine(new string('-', lineWidth));

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(new string('-', lineWidth));

            Console.WriteLine("O texto digitado foi: ");

            Console.WriteLine(text);
        }
    }
}