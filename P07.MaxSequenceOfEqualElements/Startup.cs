namespace P07.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int num = 0;
            int maxLength = 0;
            int bestIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxLength)
                {
                    maxLength = counter;
                    bestIndex = i + 1;
                }
            }
            num = (bestIndex - maxLength) + 1;
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{numbers[bestIndex]}" + " ");
            }
            Console.WriteLine();
        }
    }
}