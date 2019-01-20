namespace _09._Multiply_Evens_by_Odds
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number =Math.Abs (int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int multiple = GetMultipleOfEvenAndOddSum(evenSum, oddSum);
            Console.WriteLine(multiple);
        }

        public static int GetMultipleOfEvenAndOddSum(int evenSum, int oddSum)
        {
            int result = evenSum * oddSum;
            return result;
        }

        public static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int num = number % 10;
                if (num % 2 != 0)
                {
                    sum += num;
                }
                number /= 10;
            }
            return sum;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int num = number % 10;
                if (num % 2 == 0 )
                {
                    sum += num;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
