namespace P02.CharacterMultiplier
{
    using System;
    class Program
    {
        public static void Main()
        {
            string[] str = Console.ReadLine().Split();
            string str1 = str[0];
            string str2 = str[1];
            int result = 0;
            int[] numVal1 = new int[str[0].Length];
            int[] numVal2 = new int[str[1].Length];
            int endIndex = Math.Max(numVal1.Length, numVal2.Length);
            int startIndex = Math.Min(numVal1.Length, numVal2.Length);
            int temp = 0;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    numVal1[i] += str1[i];
                    numVal2[i] += str2[i];
                    result += numVal1[i] * numVal2[i];
                }
            }

            else if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    numVal1[i] += str1[i];
                    numVal2[i] += str2[i];
                    result += numVal1[i] * numVal2[i];
                }

                for (int i = startIndex; i < endIndex; i++)
                {
                    temp += str1[i];
                }
                result += temp;
            }
            else if (str2.Length > str1.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    numVal1[i] += str1[i];
                    numVal2[i] += str2[i];
                    result += numVal1[i] * numVal2[i];
                }

                for (int i = startIndex; i < endIndex; i++)
                {
                    temp += str2[i];
                }
                result += temp;
            }

            Console.WriteLine(result);
        }
    }
}