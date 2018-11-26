namespace P01.ReverseStrings
{
    using System;
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string result = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    result += input[i];
                }

                Console.WriteLine($"{input} = {result}");

                input = Console.ReadLine();
            }
        }
    }
}