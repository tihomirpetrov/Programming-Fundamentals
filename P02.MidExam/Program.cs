namespace P02.MidExam
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|').ToArray();

            int health = 100;
            int initialCoins = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] rooms = input[i].Split().ToArray();
                if (rooms[0] == "potion")
                {
                    int heal = int.Parse(rooms[1]);
                    if (health + heal <= 100)
                    {
                        health = health + heal;
                        Console.WriteLine($"You healed for {heal} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {heal} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }

                else if (rooms[0] == "chest")
                {
                    int coins = int.Parse(rooms[1]);
                    initialCoins += coins;
                    Console.WriteLine($"You found {coins} coins.");
                }
                else
                {
                    string monster = rooms[0];
                    int monsterAttack = int.Parse(rooms[1]);
                    health -= monsterAttack;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
        }
    }
}