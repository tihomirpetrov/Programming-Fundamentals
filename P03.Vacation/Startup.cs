namespace P03.Vacation
{
    using System;

    class Startup
    {
        public static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine().ToLower();
            string weekDay = Console.ReadLine().ToLower();
            double totalPrice = 0;

            if (weekDay == "friday")
            {
                if (groupType == "students")
                {
                    if (persons >= 30)
                    {
                        totalPrice = persons * (8.45 - (8.45 * 0.15));
                    }
                    else
                    {
                        totalPrice = persons * 8.45;
                    }
                }
                else if (groupType == "business")
                {
                    if (persons >= 100)
                    {
                        totalPrice = (persons - 10) * 10.90;
                    }
                    else
                    {
                        totalPrice = persons * 10.90;
                    }
                }
                else if (groupType == "regular")
                {
                    if (persons >= 10 && persons <= 20)
                    {
                        totalPrice = persons * (15 * 1.05);
                    }
                    else
                    {
                        totalPrice = persons * 15;
                    }
                }
            }

            else if (weekDay == "saturday")
            {
                if (groupType == "students")
                {
                    if (persons >= 30)
                    {
                        totalPrice = persons * (9.80 - (9.80 * 0.15));
                    }
                    else
                    {
                        totalPrice = persons * 9.80;
                    }
                }
                else if (groupType == "business")
                {
                    if (persons >= 100)
                    {
                        totalPrice = (persons - 10) * 15.60;
                    }
                    else
                    {
                        totalPrice = persons * 15.60;
                    }
                }
                else if (groupType == "regular")
                {
                    if (persons >= 10 && persons <= 20)
                    {
                        totalPrice = persons * (20 * 1.05);
                    }
                    else
                    {
                        totalPrice = persons * 20;
                    }
                }
            }
            else if (weekDay == "sunday")
            {
                if (groupType == "students")
                {
                    if (persons >= 30)
                    {
                        totalPrice = persons * (10.46 - (10.46 * 0.15));
                    }
                    else
                    {
                        totalPrice = persons * 10.46;
                    }
                }
                else if (groupType == "business")
                {
                    if (persons >= 100)
                    {
                        totalPrice = (persons - 10) * 16;
                    }
                    else
                    {
                        totalPrice = persons * 16;
                    }
                }
                else if (groupType == "regular")
                {
                    if (persons >= 10 && persons <= 20)
                    {
                        totalPrice = persons * (22.50 * 1.05);
                    }
                    else
                    {
                        totalPrice = persons * 22.50;
                    }
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}