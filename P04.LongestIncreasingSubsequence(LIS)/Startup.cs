namespace P04.LongestIncreasingSubsequence_LIS_
{
    using System;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxIndex = 0;
            int maxLen = 0;
            string output = string.Empty;
            
            for (int x = 0; x < sequence.Length; x++)
            {
                len[x] = 1;
                prev[x] = -1;
                for (int i = 0; i <= x; i++)
                {
                    if (sequence[x] > sequence[i] && len[i] + 1 > len[x])
                    {
                        len[x] = len[i] + 1;
                        prev[x] = i;
                    }
                }

                for (int i = 0; i < len.Length; i++)
                {
                    if (len[x] > maxLen)
                    {
                        maxLen = len[x];
                        maxIndex = x;
                        output += x;
                    }
                }
                
            }
            Console.WriteLine(maxIndex);
            Console.WriteLine(output);
            //Console.WriteLine(string.Join(" ", len));
            //Console.WriteLine(string.Join(" ", prev));

        }
    }
}