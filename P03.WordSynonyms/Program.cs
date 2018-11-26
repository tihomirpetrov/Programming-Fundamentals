namespace P03.WordSynonyms
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                var existingWords = words[word];
                existingWords.Add(synonym);
            }

            foreach (var kvp in words)
            {
                var word = kvp.Key;
                var synonymos = kvp.Value;

                Console.WriteLine($"{word} - {(string.Join(", ", synonymos))}");
            }
        }
    }
}