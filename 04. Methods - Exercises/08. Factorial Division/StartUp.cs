namespace _08._Factorial_Division
{
    using System;
    class StartUp
    {
        public static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            double firstFactorial = GetFactorialOfNumber(first);
            double secondFactorial = GetFactorialOfNumber(second);
            PrintFactorialDivision(firstFactorial, secondFactorial);
        }

        public static void PrintFactorialDivision(double firstFactorial, double secondFactorial)
        {
            Console.WriteLine($"{firstFactorial / secondFactorial :F2}");
        }

        public static double GetFactorialOfNumber(double number)
        {
            double factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
