namespace HouseParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];

                if (input[2] == "going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", guests));
        }
    }
}