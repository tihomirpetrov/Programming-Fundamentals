namespace P08.FactorialDivision
{
    using System;
    class Startup
    {
        public static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal temp = 5;

            Factorial(a, b);
            Factorial(b, a);

            //decimal result = Factorial(a) / Factorial(b);
            Console.WriteLine($"{result:f2}");
        }

        private static decimal Factorial(decimal firstNumber, decimal secondNumber = 200)
        {
            //decimal temp = 1;

            //for (decimal i = 1; i <= firstNumber; i++)
            //{
            //    temp = temp * i;
            //}
            var result = firstNumber - secondNumber;


            return result;
        }
    }
}