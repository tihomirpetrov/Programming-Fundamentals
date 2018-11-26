namespace P02.Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> userContest = new Dictionary<string, List<string>>();
            Dictionary<string, List<int>> userPoints = new Dictionary<string, List<int>>();

            while (input != "no more time")
            {
                string[] tokens = input.Split("->").ToArray();
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!userContest.ContainsKey(username))
                {
                    userContest.Add(username, new List<string>());
                    userContest[username].Add(contest);
                }

                if (!userContest.ContainsKey(username) && !userContest[username].Contains(contest))
                {
                    userPoints[username].Add(points);
                }

                input = Console.ReadLine();
            }
        }
    }
}