﻿namespace P07.AppendArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split('|');
            List<int> results = new List<int>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                int[] elements = tokens[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                results.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}