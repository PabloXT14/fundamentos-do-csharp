using System;
using System.Text;

namespace HtmlEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine(new string('-', Console.WindowWidth));

            Start();
        }

        public static void Start()
        {
            var fileText = CaptureUserInput();
            AskToSaveFile(fileText);
        }

        public static StringBuilder CaptureUserInput()
        {
            Console.WriteLine("Digite o texto (ESC para sair)");

            Console.WriteLine(new string('-', Console.WindowWidth));

            var fileText = new StringBuilder();

            do
            {
                var input = Console.ReadLine();
                fileText.AppendLine(input);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            return fileText;
        }

        public static void AskToSaveFile(StringBuilder fileText)
        {
            Console.WriteLine(new string('-', Console.WindowWidth));

            Console.WriteLine("Deseja salvar o arquivo (S/N)?");
            var option = Console.ReadLine()?.ToUpper();

            Console.WriteLine(new string('-', Console.WindowWidth));

            if (option == "S")
            {
                SaveFile(fileText);
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Menu.Show();
            }
            else if (option == "N")
            {
                Console.WriteLine("Arquivo não foi salvo.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Menu.Show();
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                AskToSaveFile(fileText);
            }
        }

        public static void SaveFile(StringBuilder fileText)
        {
            Console.WriteLine("Nome do arquivo:");

            var fileName = Console.ReadLine();
            var path = $@"{Environment.CurrentDirectory}\{fileName}.html";

            using (var file = new StreamWriter(path))
            {
                file.Write(fileText);
            }

            Console.WriteLine(new string('-', Console.WindowWidth));

            Console.WriteLine("Arquivo salvo com sucesso!");
        }
    }
}