namespace P09.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            char letter = ' ';
            List<char> result = new List<char>();
            List<string> singleString = new List<string>();
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            int repeat = 0;
            int count = 0;
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] >= 48 && input[i] <= 57)
                {
                    repeat = (int)Char.GetNumericValue(input[i]);

                    for (int j = 0; j < repeat; j++)
                    {
                        sb2.Append(sb);
                    }
                    sb.Clear();
                }
                else
                {
                    letter = input[i];
                    sb.Append(letter);
                    output += letter;
                    singleString.Add(output);
                    count++;
                }
            }
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(sb2);
        }
    }
}