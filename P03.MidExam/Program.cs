namespace P03.MidExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            List<string> beginnerQuest = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "Retire!")
            {
                string[] operations = command.Split().ToArray();

                if (operations[0] == "Start")
                {
                    string journey = operations[2] + ' ' + operations[3];
                    if (beginnerQuest.Contains(journey))
                    {

                    }
                    else
                    {
                        beginnerQuest.Add(journey);
                    }
                }

                if (operations[0] == "Complete")
                {
                    string journey = operations[2] + ' ' + operations[3];
                    if (beginnerQuest.Contains(journey))
                    {
                        for (int i = 0; i < beginnerQuest.Count; i++)
                        {
                            if (beginnerQuest[i] == journey)
                            {
                                beginnerQuest[i].Remove(i);
                            }
                        }
                        
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", beginnerQuest));
        }
    }
}