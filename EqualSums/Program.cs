namespace EqualSums
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int[] numSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numSequence.Length; i++)
            {
                rightSum += numSequence[i];              
            }

            for (int i = 0; i < numSequence.Length; i++)
            {
                rightSum -= numSequence[i];

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += numSequence[i];
            }

            Console.WriteLine("no");
        }
    }
}