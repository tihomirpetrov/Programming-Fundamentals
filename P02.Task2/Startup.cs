namespace P02.Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int initialIndex = sequence[sequence.Count - 1];

            List<int> temp = new List<int>();
            for (int i = 0; i < sequence.Count - 1; i++)
            {
                temp.Add(sequence[i]);
            }
            int counter = 0;
            sequence.RemoveAt(sequence.Count - 1);

            while (true)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    sequence[i] = sequence[i] - 1;
                }

                if (sequence[initialIndex] == 0)
                {
                    break;
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == 0)
                    {
                        sequence[i] = temp[i];
                    }
                }
                initialIndex = int.Parse(Console.ReadLine());
                counter++;

            }
            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine(counter);

        }
    }
}