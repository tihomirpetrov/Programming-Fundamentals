namespace P06.ListManipulationAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var temp = numbers;
            bool isChanged = false;
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                    isChanged = true;
                }

                if (tokens[0] == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                    isChanged = true;
                }

                if (tokens[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(tokens[1]));
                    isChanged = true;
                }

                if (tokens[0] == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), (int.Parse(tokens[1])));
                    isChanged = true;
                }

                if (tokens[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(tokens[1])))
                    {
                        Console.WriteLine("Yes");
                    }

                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                if (tokens[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(string.Join(" ", numbers[i] + " "));
                        }
                    }
                    Console.WriteLine();
                }

                if (tokens[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(string.Join(" ", numbers[i] + " "));
                        }
                    }
                    Console.WriteLine();
                }

                if (tokens[0] == "GetSum")
                {
                    Console.WriteLine(string.Join(" ", numbers.Sum()));
                }

                if (tokens[0] == "Filter")
                {
                    if (tokens[1] == "<")
                    {
                        int number = int.Parse(tokens[2]);
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                    }

                    if (tokens[1] == ">")
                    {
                        int number = int.Parse(tokens[2]);
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                    }

                    if (tokens[1] == ">=")
                    {
                        int number = int.Parse(tokens[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                    }

                    if (tokens[1] == "<=")
                    {
                        int number = int.Parse(tokens[2]);
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                    }
                }

                command = Console.ReadLine();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", temp));
            }
        }
    }
}