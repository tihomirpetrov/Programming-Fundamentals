namespace Problem3.QuestsJournal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "Retire!")
            {
                string[] input = command.Split(" - ").ToArray();

                if (input[0] == "Start")
                {
                    string quest = input[1];

                    if (!journal.Contains(quest))
                    {
                        journal.Add(quest);
                    }
                }

                if (input[0] == "Complete")
                {
                    string quest = input[1];

                    if (journal.Contains(quest))
                    {
                        journal.Remove(quest);
                    }
                }

                if (input[0] == "Side Quest")
                {
                    string quest = input[0];
                    string[] newQuest = input[1].Split(':').ToArray();

                    if (journal.Contains(newQuest[0]))
                    {
                        int index = journal.IndexOf(newQuest[0]);
                        journal.Insert(index + 1, newQuest[1]);
                    }
                    else
                    {
                        journal.Add(newQuest[0]);
                        journal.Add(newQuest[1]);
                    }
                }

                if (input[0] == "Renew")
                {
                    string quest = input[1];

                    if (journal.Contains(quest))
                    {
                        journal.Remove(quest);
                        journal.Add(quest);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}