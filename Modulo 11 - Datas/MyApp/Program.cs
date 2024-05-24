namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var data = new DateTime(); // data padrão = 01/01/0001 00:00:00

            // var data = DateTime.Now; // data atual

            // Especifica o formato da data
            var data = new DateTime(2020, 10, 12, 8, 23, 14);

            Console.WriteLine(data);

            // Obtendo partes da data
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine((int)data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
            Console.WriteLine(data.Date);
        }
    }
}
