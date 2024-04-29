using System;
using System.Text.RegularExpressions;

namespace HtmlEditor
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("# MODO DE VISUALIZAÇÃO");
            Console.WriteLine(new string('-', Console.WindowWidth));

            Replace(text);

            Console.WriteLine(new string('-', Console.WindowWidth));

            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strongText = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            Console.WriteLine(strongText.IsMatch(text) ? strongText.Replace(text, "**$1**") : text);
        }
    }
}