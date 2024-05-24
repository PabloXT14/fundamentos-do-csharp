namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var data = new DateTime(); // data padrão = 01/01/0001 00:00:00

            var data = DateTime.Now; // data atual

            Console.WriteLine(data);
        }
    }
}
