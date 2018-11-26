namespace BakingFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<int> breadBatch = new List<int>();
            List<int> quality = new List<int>();
            int bestQuality = 0;
            List<int> bestBread = new List<int>();
            List<int> totalBestBread = new List<int>();
            
            while (input != "Bake It!")
            {
                int[] tokens = input.Split('#').Select(int.Parse).ToArray();
                int sum = 0;
                int[] temp = new int[tokens.Length];

                for (int i = 0; i < tokens.Length; i++)
                {
                    int numbers = tokens[i];
                    temp[i] = numbers;
                    breadBatch.Add(numbers);
                    sum += numbers;
                }

                foreach (var bread in breadBatch)
                {
                    bestBread.Add(bread);
                }

                               

                quality.Add(sum);

                for (int i = 0; i < quality.Count; i++)
                {
                    if (bestQuality < sum)
                    {
                        bestQuality = sum;
                        totalBestBread.RemoveRange(0, totalBestBread.Count);
                        totalBestBread.AddRange(breadBatch);
                    }
                    else
                    {
                        totalBestBread.RemoveRange(0, totalBestBread.Count);
                        totalBestBread.AddRange(breadBatch);
                    }
                }

                breadBatch.RemoveRange(0, breadBatch.Count);
                bestBread.RemoveRange(0, bestBread.Count);
                input = Console.ReadLine();
            }
            
            
            if (totalBestBread.Sum() < bestBread.Sum())
            {
                Console.WriteLine($"Best Batch quality: {bestQuality}");
                Console.WriteLine(string.Join(" ", totalBestBread));
            }
            else
            {
                Console.WriteLine($"Best Batch quality: {bestQuality}");
                Console.WriteLine(string.Join(" ", bestBread));
            }


        }
    }
}