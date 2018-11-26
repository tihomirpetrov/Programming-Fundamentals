namespace TestLists
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isPrinted = true;

            for (int i = 1; i <= numbers.Length; i++)
            {
                for (int j = i; j <= numbers.Length; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        if (k == j)
                        {
                            Console.Write(k + " ");
                        }
                        else
                        {
                            Console.Write(k + ", ");
                        }
                    }
                    Console.WriteLine();
                }
                if (isPrinted)
                {
                    Console.WriteLine($"{numbers[0]}, {numbers[numbers.Length - 1]}");
                    isPrinted = false;
                }
            }
        }
    }
}