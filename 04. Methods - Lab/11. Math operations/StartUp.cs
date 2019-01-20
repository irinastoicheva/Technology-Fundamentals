namespace _11._Math_operations
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (operators == '+')
            {
                double result = GetSumOfNumbers(firstNumber, secondNumber);
                Console.WriteLine($"{Math.Round(result, 2)}");
            }
            else if (operators == '-')
            {
                double result = GetDifferenceOfNumbers(firstNumber, secondNumber);
                Console.WriteLine($"{Math.Round(result, 2)}");
            }
            else if (operators == '*')
            {
                double result = GetMultipleOfNumbers(firstNumber, secondNumber);
                Console.WriteLine($"{Math.Round(result, 2)}");
            }
            else if (operators == '/')
            {
                double result = GetPrivateOfNumbers(firstNumber, secondNumber);
                Console.WriteLine($"{Math.Round(result, 2)}");
            }
        }

        public static double GetPrivateOfNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public static double GetMultipleOfNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double GetDifferenceOfNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double GetSumOfNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
