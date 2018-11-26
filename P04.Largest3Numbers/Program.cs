namespace P04.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] sortedNumbers = numbers.OrderByDescending(n => n).ToArray();
            int length = 3;

            for (int i = 0; i < length; i++)
            {
                if (sortedNumbers.Length < length)
                {
                    length = sortedNumbers.Length;
                }

                Console.Write(sortedNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}