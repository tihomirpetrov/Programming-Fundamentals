namespace P01.DataBalance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        public static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Length >= 3 && usernames[i].Length <= 16)
                {
                    string name = usernames[i];
                    if (IsAllLettersOrDigits(name))
                    {
                        Console.WriteLine(usernames[i]);
                    }
                }
            }
        }
        public static bool IsAllLettersOrDigits(string username)
        {
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c) && c != '-' && c != '_')
                    return false;
            }
            return true;
        }
    }
}