namespace Problem2.DungeonestDark
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int initialHealth = 100;
            int initialCoins = 0;
            string[] dungeonRooms = input.Split('|').ToArray();
            int count = 0;

           
            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                if (count == dungeonRooms.Length)
                {
                    return;
                }
                string[] rooms = dungeonRooms[i].Split(' ').ToArray();
                count++;
                if (rooms[0] == "potion")
                {
                    int heal = int.Parse(rooms[1]);

                    if (initialHealth + heal <= 100)
                    {
                        initialHealth += heal;
                        Console.WriteLine($"You healed for {heal} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    else 
                    {
                        heal = 100 - initialHealth;
                        initialHealth += heal;
                        Console.WriteLine($"You healed for {heal} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                }


                else if (rooms[0] == "chest")
                {
                    int chest = int.Parse(rooms[1]);
                    initialCoins += chest;
                    Console.WriteLine($"You found {chest} coins.");
                }

                else
                {
                    string monster = rooms[0];
                    int monsterAttack = int.Parse(rooms[1]);
                    initialHealth -= monsterAttack;

                    if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {count}");
                        return;                        
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {initialCoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}