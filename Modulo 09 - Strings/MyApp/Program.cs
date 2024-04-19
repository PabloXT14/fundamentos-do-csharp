using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AulaStringInterpolation();
        }

        static void AulaGuid()
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

        static void AulaStringInterpolation()
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
    }
}
