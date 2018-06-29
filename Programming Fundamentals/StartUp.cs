namespace GetDayOfWeek
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string[] days = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
        };
            int dayOfWeek = int.Parse(Console.ReadLine());
            if (dayOfWeek >= 1 && dayOfWeek <= 7)
            {
                Console.WriteLine(days[dayOfWeek - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}