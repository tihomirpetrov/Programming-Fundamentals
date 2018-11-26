namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int number = 0;
            int maxLength = 1;
            int bestIndex = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                
                if (sequence[i] == sequence[i + 1])
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

            number = (bestIndex - maxLength) + 1;

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{sequence[bestIndex]}" + " ");
            }
            Console.WriteLine();
        }
    }
}