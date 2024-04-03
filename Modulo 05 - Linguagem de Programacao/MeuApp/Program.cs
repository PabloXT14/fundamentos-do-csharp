using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(1, "Mouse Gamer", 197.99);

            Console.WriteLine(product.Id);
            Console.WriteLine(product.Title);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.PriceInDollar(5.70));
        }
    }

    struct Product
    {
        public int Id;
        public string Title;
        public double Price;

        public Product(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public double PriceInDollar(double dollar)
        {
            return Price * dollar;
        }
    }
}
