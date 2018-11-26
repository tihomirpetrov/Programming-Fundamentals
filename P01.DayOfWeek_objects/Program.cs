using System;
using System.Globalization;

namespace P01.DayOfWeek_objects
{
    class Program
    {
        public static void Main()
        {
            string date = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dt.DayOfWeek);
        }
    }
}