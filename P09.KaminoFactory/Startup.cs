namespace P09.KaminoFactory
{
    using System;
    using System.Linq;
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] sequence = new int[n];
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            int[] bestSequence = new int[n];
            int counter = 0;
            while (input != "Clone them!")
            {
                sequence = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                counter++;
                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    for (int j = i + 1; j < sequence.Length - 1; j++)
                    {
                        if (sequence[i] == sequence[j] && sequence[i] != 0)
                        {
                            bestSequenceIndex = sequence[i];
                            bestSequenceSum += sequence[i];
                        }
                    }
                }
                input = Console.ReadLine();
            }
            bestSequenceIndex = Math.Abs(bestSequenceIndex - counter);
            bestSequenceSum = counter;
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}