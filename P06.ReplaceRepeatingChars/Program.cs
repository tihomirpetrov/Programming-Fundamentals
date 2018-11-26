namespace P06.ReplaceRepeatingChars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<char> result = new List<char>();
            

            for (int i = 0; i < input.Length; i++)
            {
                result.Add(input[i]);
            }

            for (int j = 0; j < result.Count - 1; j++)
            {
                if (result[j] == result[j + 1])
                {
                    result.RemoveAt(j);
                    j--;
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}