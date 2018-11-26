namespace P05.ListManipulationBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        public static void Main()
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }

                if (tokens[0] == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                }

                if (tokens[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(tokens[1]));
                }

                if (tokens[0] == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), (int.Parse(tokens[1])));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}