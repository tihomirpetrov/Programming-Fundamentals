namespace P03.RecursiveFibonacci
{
    using System;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n + 1];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }
            Console.WriteLine(fibonacci[fibonacci.Length - 1]);
        }
    }
}