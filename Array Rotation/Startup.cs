namespace Array_Rotation
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int temp = numbers[0];
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}