namespace P04.ListOfProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }

            for (int i = 0; i < products.Count; i++)
            {
                products.Sort();
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}