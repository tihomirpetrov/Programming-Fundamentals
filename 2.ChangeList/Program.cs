namespace ChangeList
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

            while (input != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);
                    numbers.RemoveAll(x => x == number);
                }

                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}