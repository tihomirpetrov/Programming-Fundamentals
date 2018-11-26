namespace Pascal_Triangle
{
    using System;
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] line = new int[n];

            for (int i = 1; i <= line.Length; i++)
            {
                int[] col = new int[i];
                col[0] = 1;

                for (int j = 1; j < i; j++)
                {
                    col[j] = line[j] + line[j - 1];                    
                }
                Console.WriteLine(string.Join(" ", col));

                for (int k = 0; k < col.Length; k++)
                {
                    line[k] = col[k];
                }
            }
        }
    }
}