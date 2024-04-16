using System;
using System.IO;

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
            Console.Clear();

            Console.WriteLine("Qual o caminho do arquivo?");

            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();

                Console.WriteLine(new string('-', lineWidth));
                Console.WriteLine("Conteúdo do arquivo: ");

                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();

            Menu();
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

            Save(text);

            Menu();
        }

        static void Save(string text)
        {
            Console.Clear();

            Console.WriteLine("Qual caminho para salvar o arquivo?");

            var path = Console.ReadLine();

            // using => abre e fecha de forma automática o que for passado como parâmetro
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");

            Console.ReadLine();
        }
    }
}