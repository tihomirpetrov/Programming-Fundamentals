namespace Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int countWagons = int.Parse(Console.ReadLine());
            int[] peopleInEachWagon = new int[countWagons];
            int sum = 0;

            for (int i = 0; i < countWagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                peopleInEachWagon[i] += people;
            }

            for (int i = 0; i < peopleInEachWagon.Length; i++)
            {
                Console.Write(peopleInEachWagon[i] + " ");
                sum += peopleInEachWagon[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}