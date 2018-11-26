namespace P02.Passed
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade <= 2.99)
            {
                Console.WriteLine("Failed!");
            }
            else
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}