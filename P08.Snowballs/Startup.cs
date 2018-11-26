namespace P08.Snowballs
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int numberOfSnowBalls = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            int snowballValue = 0;
            int highestResult = int.MinValue;
            for (int i = 0; i < numberOfSnowBalls; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = (snowballSnow / snowballTime) ^ snowballQuality;
                if (snowballValue > highestResult)
                {
                    highestResult = snowballValue;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {highestResult} ({snowballQuality})");
        }
    }
}