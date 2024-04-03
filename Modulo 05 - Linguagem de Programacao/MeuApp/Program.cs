using System; // Como o System já é implícito, mesmo não importando ele, já por padrão nos tipos que precisam dele 

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(1, "Mouse Gamer", 197.99, EProductType.Product);
            var eletricMaintenance = new Product(2, "Eletric Maintenance", 99.99, EProductType.Service);

            Console.WriteLine("Product: ");
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Title);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.PriceInDollar(5.70));
            Console.WriteLine(product.Type);
            Console.WriteLine((int)product.Type);

            Console.WriteLine(new string('-', 70));

            Console.WriteLine("Eletric Maintenance: ");
            Console.WriteLine(eletricMaintenance.Id);
            Console.WriteLine(eletricMaintenance.Title);
            Console.WriteLine(eletricMaintenance.Price);
            Console.WriteLine(eletricMaintenance.PriceInDollar(5.70));
            Console.WriteLine(eletricMaintenance.Type);
            Console.WriteLine((int)eletricMaintenance.Type);
        }
    }

    struct Product
    {
        public int Id;
        public string Title;
        public double Price;

        public EProductType Type;

        public Product(int id, string title, double price, EProductType type)
        {
            Id = id;
            Title = title;
            Price = price;
            Type = type;
        }

        public double PriceInDollar(double dollar)
        {
            return Price * dollar;
        }
    }
    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
