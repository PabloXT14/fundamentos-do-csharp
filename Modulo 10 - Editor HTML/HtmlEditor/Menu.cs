using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue; // cor de fundo
            Console.ForegroundColor = ConsoleColor.Black; // cor do texto

            Console.WriteLine("EDITOR HTML");
        }
    }
}