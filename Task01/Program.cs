using System;
using System.Collections.Generic;
using System.Linq;

namespace Task01
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<string> result = GetAllCombinations(input);

            Console.WriteLine($"You have {result.Count} combinations:");
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
                Console.WriteLine();
            }
        }

        private static List<string> GetAllCombinations(List<int> input)
        {
            List<string> allCombinations = new List<string>();
            string str = string.Empty;
            double comb = Math.Pow(2, input.Count);

            for (int i = 1; i <= comb - 1; i++)
            {
                int counter = 0;
                string startingBitZero = Convert.ToString(i, 2).PadLeft(input.Count, '0');
                for (int j = 0; j < startingBitZero.Length; j++)
                {
                    if (startingBitZero[j] == '1')
                    {
                        if (j == startingBitZero.Length - 1)
                        {
                            str += input[j];
                        }
                        else
                        {                            
                            str += input[j] + ", ";
                        }
                        counter++;
                    }
                }

                str = str.Trim(' ');
                if (str.EndsWith(','))
                {
                    str = str.Remove(str.Length - 1);
                }
                allCombinations.Add(str);
                str = string.Empty;
            }

            allCombinations.Sort();
            return allCombinations;
        }
    }
}
