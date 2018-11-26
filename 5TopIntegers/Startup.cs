namespace TopIntegers
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int number = numbers[i];

                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        int secondNumber = numbers[j];

                        if (number <= secondNumber)
                        {
                            break;
                        }
                        else if (j == numbers.Length - 1)
                        {
                            Console.Write(number + " ");
                        }
                    }
                }
                Console.WriteLine(numbers[numbers.Length - 1]);
            }
        }
    }
}