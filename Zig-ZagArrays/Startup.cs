namespace Zig_ZagArrays
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] finalFirst = new string[n];
            string[] finalSecond = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (i % 2 == 0)
                {
                    finalFirst[i] = input[0];
                    finalSecond[i] = input[1];
                }
                else
                {
                    finalFirst[i] = input[1];
                    finalSecond[i] = input[0];
                }                
            }
            Console.WriteLine(string.Join(" ", finalFirst));
            Console.WriteLine(string.Join(" ", finalSecond));
        }
    }
}