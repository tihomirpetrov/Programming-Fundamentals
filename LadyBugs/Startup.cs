namespace LadyBugs
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] allIndexes = new int[sizeOfField];
            int[] initialIndexesOfBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ladyBug = 0;

            for (int i = 0; i < initialIndexesOfBugs.Length; i++)
            {
                ladyBug = initialIndexesOfBugs[i];
                if (ladyBug >= 0 && ladyBug < allIndexes.Length)
                {
                    allIndexes[ladyBug] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split().ToArray();

                int ladybugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                if (ladybugIndex >= 0 && ladybugIndex < sizeOfField && flyLength != 0)
                {
                    if (allIndexes[ladybugIndex] == 1)
                    {
                        if (direction == "right")
                        {

                            if (ladybugIndex + flyLength >= sizeOfField || ladybugIndex + flyLength < 0)
                            {
                                allIndexes[ladybugIndex] = 0;
                            }

                            else
                            {
                                if (allIndexes[ladybugIndex + flyLength] == 0)
                                {
                                    allIndexes[ladybugIndex] = 0;
                                    allIndexes[ladybugIndex + flyLength] = 1;
                                }
                                else
                                {
                                    for (int i = ladybugIndex; i < sizeOfField; i += flyLength)
                                    {
                                        if (allIndexes[i] == 0)
                                        {
                                            allIndexes[i] = 1;
                                            break;
                                        }
                                    }
                                    allIndexes[ladybugIndex] = 0;
                                }
                            }
                        }
                        else if (direction == "left")
                        {

                            if (ladybugIndex - flyLength >= sizeOfField || ladybugIndex - flyLength < 0)
                            {
                                allIndexes[ladybugIndex] = 0;
                            }

                            else
                            {
                                if (allIndexes[ladybugIndex - flyLength] == 0)
                                {
                                    allIndexes[ladybugIndex] = 0;
                                    allIndexes[ladybugIndex - flyLength] = 1;
                                }
                                else
                                {
                                    for (int i = ladybugIndex; i < sizeOfField; i -= flyLength)
                                    {
                                        if (allIndexes[i] == 0)
                                        {
                                            allIndexes[i] = 1;
                                            break;
                                        }
                                    }
                                    allIndexes[ladybugIndex] = 0;
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", allIndexes));
        }
    }
}