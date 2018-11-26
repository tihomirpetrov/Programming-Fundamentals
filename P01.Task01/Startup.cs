namespace P01.Task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            int amountRegions = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double[] regionalCoeff = new double[amountRegions];
            double sumRegions = 0.0;
            for (int i = 0; i < amountRegions; i++)
            {
                double[] information = Console.ReadLine().Split().Select(double.Parse).ToArray();

                regionalCoeff[i] = information[0] / information[1];
                sumRegions += regionalCoeff[i];
            }

            double average = sumRegions / density;

            double result = double.IsInfinity(average) ? sumRegions : average;

            Console.WriteLine($"{result:f3}");
            //if (double.IsInfinity(average))
            //{
            //    Console.WriteLine($"{sumRegions:}");
            //}
            //else
            //{
            //    Console.WriteLine($"{average:f3}");
            //}
        }
    }
}