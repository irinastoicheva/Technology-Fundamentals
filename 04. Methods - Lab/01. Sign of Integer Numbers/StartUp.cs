namespace _01._Sign_of_Integer_Numbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintSingOfNumber(number);
        }

        private static void PrintSingOfNumber(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
    }
}
