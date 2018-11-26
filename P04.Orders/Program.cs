namespace P04.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<double, int>> namePrice = new Dictionary<string, Dictionary<double, int>>();

            while (command != "buy")
            {
                string[] input = command.Split().ToArray();
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!namePrice.ContainsKey(name))
                {
                    namePrice.Add(name, new Dictionary<double, int>());
                    namePrice[name].Add(price, quantity);
                }
                else if (!namePrice[name].ContainsKey(price))
                {
                    var tempQuantity = namePrice[name].Values.Sum();
                    namePrice.Remove(name);
                    namePrice.Add(name, new Dictionary<double, int>());
                    namePrice[name].Add(price, quantity + tempQuantity);
                }
                else
                {
                    namePrice[name][price] += quantity;
                }

                command = Console.ReadLine();
            }
            foreach (var name in namePrice)
            {
                foreach (var price in name.Value)
                {
                    Console.WriteLine($"{name.Key} -> {price.Key * price.Value:f2}");
                }
            }
        }
    }
}