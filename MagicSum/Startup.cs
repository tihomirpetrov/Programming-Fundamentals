namespace MagicSum
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (sequence[i] + sequence[j] == number)
                    {
                        Console.WriteLine($"{sequence[i]} {sequence[j]}");
                    }
                }
                
            }
        }
    }
}