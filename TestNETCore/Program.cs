namespace TestNETCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var handsOfCards = new Dictionary<string, Dictionary<int, List<int>>>();

            while (input != "JOKER")
            {
                string[] inputArgs = input.Split(new char[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string playerName = inputArgs[0];

                if (!handsOfCards.ContainsKey(playerName))
                {
                    handsOfCards.Add(playerName, new Dictionary<int, List<int>>());
                    for (int i = 1; i <= 4; i++)
                    {
                        handsOfCards[playerName].Add(i, new List<int>());
                    }
                }

                for (int i = 1; i < inputArgs.Length; i++)
                {
                    int cardPower = 0;
                    int cardType = 0;

                    string card = inputArgs[i];

                    if (card.Length > 2)
                    {
                        cardPower = GetCardPower(card.Substring(0, 2));
                        cardType = GetCardType(card.Substring(2));
                    }

                    else
                    {
                        cardPower = GetCardPower(card.Substring(0, 1));
                        cardType = GetCardType(card.Substring(1));
                    }

                    if (handsOfCards[playerName][cardType].Contains(cardPower) == false)
                    {
                        handsOfCards[playerName][cardType].Add(cardPower);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in handsOfCards)
            {
                int sum = 0;
                foreach (var cardType in player.Value)
                {
                    int sumCardPower = 0;
                    foreach (var cardPower in cardType.Value)
                    {
                        sumCardPower += cardPower;
                    }
                    sum += cardType.Key * sumCardPower;
                }
                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
        

        private static int GetCardType(string card)
        {
            switch (card)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return int.Parse(card);
            }
        }

        private static int GetCardPower(string card)
        {
            switch (card)
            {
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(card);
            }
        }
    }
}