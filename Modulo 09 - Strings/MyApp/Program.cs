using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static int lineWidth = 70;

        static void Main(string[] args)
        {
            StringBuilderMethod();
        }

        static void GenerateGuid()
        {
            // Guid (Global Unique Identifier - Identificador Único Global) já vem por padrão no System

            var id = Guid.NewGuid();

            // Transformando o Guid em uma string
            // id.ToString();

            // Gerando um Guid com uma string
            // id = new Guid("8f2f5f8f-2f5f-5f8f-8f2f-5f8f8f8f8f8f"); // Ok
            // id = new Guid(""); // Erro

            // Guid todo zerado
            // id = new Guid();

            Console.WriteLine($"id: {id}");
            Console.WriteLine($"id cortado: {id.ToString().Substring(0, 8)}");
        }

        static void StringInterpolation()
        {
            var price = 10.2;
            var text1 = "O preço do produto é R$ " + price + " apenas na promoção";
            var text2 = string.Format(
                "O preço do produto é R$ {0} apenas na promoção (sem promoção é R$ {1})",
                price * 0.9,
                price
            );
            var text3 = $"O preço do produto é R$ {price} apenas na promoção";

            // O @ permite quebras de linha e caracteres especiais sejam usados
            var text4 = $@"O preço do produto é
            R$ {price * 0.9} apenas na promoção (sem promoção é R$ {price})";

            Console.WriteLine(text4);
        }

        static void ComparingStrings()
        {
            var text = "Hello, World!";

            Console.WriteLine(text.CompareTo("Hello, World!")); // 0

            Console.WriteLine(text.CompareTo("hello, World!")); // 1

            Console.WriteLine(text.CompareTo("Random Text")); // -1

            Console.WriteLine(new string('-', Console.WindowWidth));

            Console.WriteLine(text.Contains("World")); // true
            Console.WriteLine(text.Contains("world")); // false
            Console.WriteLine(text.Contains("world", StringComparison.OrdinalIgnoreCase)); // true
            Console.WriteLine(text.Contains(null)); // Erro
        }

        static void StartsWithAndEndsWith()
        {
            string text = "Hello, World!";

            Console.WriteLine(text.StartsWith("Hello")); // true
            Console.WriteLine(text.StartsWith("hello")); // false
            Console.WriteLine(text.StartsWith("hello", StringComparison.OrdinalIgnoreCase)); // true
            Console.WriteLine(text.StartsWith("Radom text")); // false

            Console.WriteLine(new string('-', Console.WindowWidth));

            Console.WriteLine(text.EndsWith("World!")); // true
            Console.WriteLine(text.EndsWith("world!")); // false
            Console.WriteLine(text.EndsWith("world!", StringComparison.OrdinalIgnoreCase)); // true
            Console.WriteLine(text.EndsWith("Radom text")); // false 
        }

        static void EqualsComparison()
        {
            string text = "Hello, World!";
            int number = 10;

            // Equals: neste caso o conteúdo comparado precisa ser exatamente igual para retornar true (disponível para qualquer tipo de objeto em C#)
            Console.WriteLine(text.Equals("Hello, World!")); // true
            Console.WriteLine(text.Equals("hello, World!")); // false
            Console.WriteLine(text.Equals("hello, world!", StringComparison.OrdinalIgnoreCase)); // true

            Console.WriteLine(new string('-', lineWidth));

            Console.WriteLine(number.Equals(10)); // true
            Console.WriteLine(number.Equals(11)); // false
        }

        static void Indexes()
        {
            string text = "Hello, World!";

            Console.WriteLine(text[0]); // H
            Console.WriteLine(text.IndexOf("o")); // 4
            Console.WriteLine(text.LastIndexOf("o")); // 8
        }

        static void AdditionalMethods()
        {
            string text = "Hello, World!";

            Console.WriteLine(text.ToUpper()); // HELLO, WORLD!
            Console.WriteLine(text.ToLower()); // hello, world!
            Console.WriteLine(text.Insert(6, " to an awesome")); // Hello, to an awesome World!
            Console.WriteLine(text.Remove(5, 8)); // Hello
            Console.WriteLine(text.Length); // 13
        }

        static void HandlingStrings()
        {
            var text = "Hello, World!";
            var text2 = "I have a dream";
            var text3 = "     Think different     ";

            Console.WriteLine(text.Replace("Hello", "Hi")); // Hi, World!

            var words = text2.Split(" ");
            Console.WriteLine(words[0]); // I
            Console.WriteLine(words[1]); // have

            var initialWord = text.Substring(0, 5);
            Console.WriteLine(initialWord); // Hello

            Console.WriteLine(text3);
            Console.WriteLine(text3.Trim()); // Think different
        }

        static void StringBuilderMethod()
        {
            // StringBuilder: classe que serve para criar strings dinamicamente, recomendado para strings com muito conteúdo, para ler ou criar de forma performática uma string que tenha muito conteúdo
            var text = new StringBuilder("Hello, World!");

            text.Append(" Thanks for using my program!");
            text.Append(" I hope you enjoy it!");

            Console.WriteLine(text); // o variável text é um objeto de StringBuilder, no entanto o Console.WriteLine converte o StringBuilder em uma string automaticamente
            Console.WriteLine(text.ToString()); // o método ToString() converte o StringBuilder em uma string
        }
    }
}
