using System;

namespace HtmlEditor
{
    public static class Menu
    {
        static int screenWidth = 70;

        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black; // cor de fundo
            Console.ForegroundColor = ConsoleColor.Green; // cor do texto

            DrawScreen();

            var option = WriteOptions();

            HandleMenuOption(option);

            // Reset color
            Console.ResetColor();

            // Keeping the console window open
            Console.ReadLine();
        }

        public static void DrawScreen()
        {
            var width = screenWidth;
            var lineAmount = 10;

            // Draw top
            DrawBorderTop(width);

            // Draw body
            DrawScreenLine(width, lineAmount);

            // Draw bottom
            DrawBorderBottom(width);
        }

        public static void DrawBorderTop(int width)
        {
            Console.WriteLine("╔" + new string('═', width - 2) + "╗");
        }

        public static void DrawBorderBottom(int width)
        {
            Console.WriteLine("╚" + new string('═', width - 2) + "╝");
        }

        public static void DrawScreenLine(int lineWidth, int lineAmount)
        {
            for (int line = 0; line < lineAmount; line++)
            {
                Console.WriteLine("║" + new string(' ', lineWidth - 2) + "║");
            }
        }

        public static short WriteOptions()
        {
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("# Editor HTML");

            Console.SetCursorPosition(2, 2);
            Console.WriteLine(new string('-', screenWidth - 4));

            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Selecione uma opção abaixo:");

            Console.SetCursorPosition(2, 4);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(2, 5);
            Console.WriteLine("2 - Abrir arquivo");

            Console.SetCursorPosition(2, 6);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(2, 8);
            Console.Write("Opção: ");

            var option = short.Parse(Console.ReadLine());

            Console.SetCursorPosition(2, 10);

            return option;
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}