namespace KaminoFactory
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            int length = 0;
            int startIndex = -1;
            int row = 0;
            int currentRow = 1;
            int[] dna = new int[dnaLength];

            while (input != "Clone them!")
            {
                int[] dnaSequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentStartIndex = -1;
                int currentLength = 0;
                int currentSum = 0;
                bool isFound = false;

                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    if (dnaSequence[i] == 1)
                    {
                        currentSum++;
                    }
                }

                if (currentRow == 1)
                {
                    dna = dnaSequence;
                    row = currentRow;
                    sum = currentSum;
                }

                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    if (dnaSequence[i] == 1)
                    {
                        if (!isFound)
                        {
                            currentStartIndex = i;
                        }

                        currentLength++;

                        if (currentLength > length)
                        {
                            length = currentLength;
                            startIndex = currentStartIndex;
                            sum = currentSum;
                            row = currentRow;
                            dna = dnaSequence;
                        }
                        else if (currentLength == length)
                        {
                            if (currentStartIndex < startIndex)
                            {
                                length = currentLength;
                                startIndex = currentStartIndex;
                                sum = currentSum;
                                row = currentRow;
                                dna = dnaSequence;
                            }

                            else if (currentSum > sum)
                            {
                                length = currentLength;
                                startIndex = currentStartIndex;
                                sum = currentSum;
                                row = currentRow;
                                dna = dnaSequence;
                            }
                        }
                    }

                    else
                    {
                        currentStartIndex = -1;
                        currentLength = 0;
                        isFound = false;
                    }
                }

                currentRow++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {row} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", dna));
        }
    }
}