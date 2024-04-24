using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black; // cor de fundo
            Console.ForegroundColor = ConsoleColor.Green; // cor do texto

            DrawScreen();

            // Reset color
            Console.ResetColor();

            // Keeping the console window open
            Console.ReadLine();
        }

        public static void DrawScreen()
        {
            var width = 70;
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
    }
}