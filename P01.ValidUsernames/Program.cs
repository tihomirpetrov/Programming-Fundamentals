namespace P01.ValidUsernames
{
    using System;
    using System.Collections.Generic;


    class Program
    {
        public static object Set { get; private set; }

        public static void Main()
        {
            string[] names = Console.ReadLine().Split(", ");
            List<string> validUsers = new List<string>();
            bool isValid = false;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length >= 3 && names[i].Length <= 16)
                {
                    isValid = true;

                    string name = names[i];
                    foreach (var letter in name)
                    {
                        if (char.IsLetterOrDigit(letter) == false && letter != '_' && letter != '-')
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        validUsers.Add(names[i]);
                    }
                }                              
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUsers));
        }
    }
}