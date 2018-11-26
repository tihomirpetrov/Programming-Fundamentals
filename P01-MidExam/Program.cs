namespace P01.MidExam
{
    using System;
    class Program
    {
        public static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;                        
          
            
            for (int i = 1; i <= days; i++)
            {
                if (i % 15 == 0)
                {
                    partySize += 5;                    
                }                

                if (i % 10 == 0 )
                {
                    partySize -= 2;                   
                }

                coins += 50;
                coins -= (2 * partySize);

                if (i % 3 == 0)
                {
                    coins -= 3 * partySize;
                }                

                if (i % 5 == 0)
                {
                    coins += 20 * partySize;
                    if (i % 3 == 0)
                    {
                        coins -= 2 * partySize;
                    }
                }
            }

            coins = coins / partySize;

            Console.WriteLine($"{partySize} companions received {coins} coins each.");

        }
    }
}