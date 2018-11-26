namespace P03.ExtractFile
{
    using System;
    using System.IO;
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            string extension = string.Empty;

            result = Path.GetFileNameWithoutExtension(input);
            extension = Path.GetExtension(input).Replace(".", "");

            Console.WriteLine($"File name: {result}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}