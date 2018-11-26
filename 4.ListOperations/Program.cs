namespace ListOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
         {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split().ToArray();
                string operation = commands[0];

                if (operation == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Add(number);
                }

                else if (operation == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    numbers.Insert(index, number);
                    }
                }

                else if (operation == "Remove")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");                        
                    }
                    else
                    {
                    numbers.RemoveAt(index);
                    }
                }

                else if (operation == "Shift")
                {
                    string direction = commands[1];
                    if (direction == "left")
                    {
                        int count = int.Parse(commands[2]);
                        count %= numbers.Count;
                        for (int i = 0; i < count; i++)
                        {
                            int firstNumber = numbers[0];
                            numbers.Remove(numbers[0]);
                            numbers.Add(firstNumber);
                        }

                    }
                    else
                    {
                        int count = int.Parse(commands[2]);
                        count %= numbers.Count;
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            numbers.Remove(numbers[numbers.Count - 1]);
                            numbers.Insert(0, lastNumber);
                        }                        
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}