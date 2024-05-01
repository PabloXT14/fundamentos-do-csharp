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
            // Console.WriteLine(strongText.IsMatch(text) ? strongText.Replace(text, "**$1**") : text);

            var words = text.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                // Verifica se a palavra contém a tag strong (ou seja, se esta em negrito)
                if (strongText.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    var word = words[i].Substring(
                        words[i].IndexOf('>') + 1, // inicia na posicao depois da primeira ocorrencia da tag strong
                        (
                            // pega a quantidade de caracteres entre a primeira e a ultima ocorrencia da tag strong
                            (words[i].LastIndexOf('<') - 1) -
                            words[i].IndexOf('>')
                        )
                    );

                    Console.Write(word);

                    Console.Write(" ");

                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}