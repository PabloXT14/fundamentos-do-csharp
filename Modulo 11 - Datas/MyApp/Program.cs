namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            FormattingDates();
        }

        public static void StartingWithDate()
        {
            // var data = new DateTime(); // data padrão = 01/01/0001 00:00:00

            // var data = DateTime.Now; // data atual

            // Especifica o formato da data
            var data = new DateTime(2020, 10, 12, 8, 23, 14);

            Console.WriteLine(data);
        }

        public static void GettingDateValues()
        {
            var data = DateTime.Now;

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

        public static void FormattingDates()
        {
            var date = DateTime.Now;

            Console.WriteLine("# Formatando Datas");

            Console.WriteLine(new string('-', Console.WindowWidth));

            /*
                - yyyy = ano com 4 digitos
                - yy = ano com 2 digitos
                - y = ano com o mês 
                - M = mês por extenso
                - MM = mês com 2 digitos
                - dd = dia com 2 digitos
                - d = dia/mes/ano
                - hh = hora com 2 digitos
                - mm = minuto com 2 digitos
                - ss = segundo com 2 digitos
                - ff - fracão de segundo
                - z = timezone ou fuso horário

            */
            var dateFormatted = String.Format("{0:yyyy/MM/dd hh:mm:ss ff z}", date);

            Console.WriteLine(dateFormatted);
        }
    }
}
