namespace MemoryView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<int> numInput = new List<int>();
            string result = string.Empty;
            int sizeOfWord = 0;

            while (input != "Visual Studio crash")
            {
                numInput = input.Split().Select(int.Parse).ToList();

                for (int i = 0; i < numInput.Count; i++)
                {
                    if (numInput[i] == 32656 && numInput[i + 1] == 19759 && numInput[i + 2] == 32763)
                    {
                        if (numInput[i + 3] == 0)
                        {
                            for (int j = numInput[i + 5]; j < numInput.Count; j++)
                            {
                                sizeOfWord += numInput[j + i];
                            }
                        }                        
                    }
                }



                input = Console.ReadLine();
            }

        }
    }
}
