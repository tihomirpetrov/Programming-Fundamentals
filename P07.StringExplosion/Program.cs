namespace P07.StringExplosion
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] sequence = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                sequence[i] = input[i];
            }

            int power = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '>')
                {
                    if (i + 1 < sequence.Length)
                    {
                        if (power < 0)
                        {
                            power = 0;
                        }
                        power += (int)(sequence[i + 1] - 47);
                    }
                }

                if (power > 0 && sequence[i] != '>')
                {
                    sequence[i] = (char)0;
                }

                power--;
            }

            foreach (var item in sequence)
            {
                if (item != (char)0)
                {
                    Console.Write(item);
                }
            }
        }
    }
}