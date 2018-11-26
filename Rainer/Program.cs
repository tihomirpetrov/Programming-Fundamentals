namespace Rainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int nextIndex = sequence[sequence.Count - 1];
            List<int> originalSequence = new List<int>();
            int counter = 0;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                int number = sequence[i];
                originalSequence.Add(number);
            }

            sequence.RemoveAt(sequence.Count - 1);

            while (true)
            {

                for (int i = 0; i < sequence.Count; i++)
                {
                    sequence[i] -= 1;   
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[nextIndex] == 0)
                    {
                        Console.WriteLine(string.Join(" ", sequence));
                        Console.WriteLine(counter);
                        return;
                    }
                    
                    if (sequence[i] == 0)
                    {
                        sequence[i] = originalSequence[i];
                    }
                }
                nextIndex = int.Parse(Console.ReadLine());
                counter++;
            }
        }
    }
}