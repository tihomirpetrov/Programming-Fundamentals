namespace P07.MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            int biggerList = 0;
            int smallList = 0;

            if (firstNumbers.Count >= secondNumbers.Count)
            {
                biggerList = firstNumbers.Count;
                smallList = secondNumbers.Count;
            }

            else
            {
                biggerList = secondNumbers.Count;
                smallList = firstNumbers.Count;
            }

            for (int i = 0; i < smallList; i++)
            {
                result.Add(firstNumbers[i]);
                result.Add(secondNumbers[i]);
            }
            for (int j = smallList; j < biggerList; j++)
            {
                if (biggerList == firstNumbers.Count)
                {
                    result.Add(firstNumbers[j]);
                }
                else
                {
                    result.Add(secondNumbers[j]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}