namespace P08.LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            double sum = 0;

            List<string> sequences = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < sequences.Count; i++)
            {
                string line = sequences[i];
                double letterBefore = (int)(line[0]);
                double letterAfter = (int)(line[line.Length - 1]);
                double number = 0;
                string test = string.Empty;

                for (int j = 1; j < line.Length - 1; j++)
                {
                    number = (int)Char.GetNumericValue(line[j]);
                    test += number;
                }

                number = double.Parse(test);

                if (letterBefore >= 65 && letterBefore <= 90)
                {
                    sum += (number / (letterBefore - 64));
                }
                else if (letterBefore >= 97 && letterBefore <= 122)
                {
                    sum += (number * (letterBefore - 96));
                }

                if (letterAfter >= 65 && letterAfter <= 90)
                {
                    sum = sum - (letterAfter - 64);
                }
                else if (letterAfter >= 97 && letterAfter <= 122)
                {
                    sum = sum + (letterAfter - 96);
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}