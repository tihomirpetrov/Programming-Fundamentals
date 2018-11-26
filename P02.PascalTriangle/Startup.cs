namespace P02.PascalTriangle
{
    using System;
    using System.Linq;
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int c = 1;
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write($"{c} ");
                    c = c * (i - k) / (k + 1);
                }
                Console.WriteLine();
            }
        }
    }
}