namespace P01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.RemoveAll(n => n < 0);                
            }
                        
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}