namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bombNumber = input[0];
            int bombPower = input[1];
            int startDetonate = 0;
            int endDetonate = 0;

            for (int i = 0; i < sequence.Count; i++)
            {

                if (bombNumber == sequence[i])
                {
                    startDetonate = i - bombPower;
                    endDetonate = i + bombPower;

                    if (startDetonate < 0)
                    {
                        startDetonate = 0;
                    }

                    if (endDetonate > sequence.Count - 1)
                    {
                        endDetonate = sequence.Count - 1;
                    }

                    if (startDetonate > sequence.Count -1 || endDetonate < 0)
                    {
                        continue;
                    }
                    sequence.RemoveRange(startDetonate, endDetonate - startDetonate + 1);
                    i = startDetonate - 1;
                }
                
            }
            Console.WriteLine(sequence.Sum());

        }
    }
}