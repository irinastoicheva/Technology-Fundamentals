namespace _01._Smallest_of_Three_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            PrintTheSmallestOfNumbers(firstNumber, secondNumber, thirdNumber);
        }

        private static void PrintTheSmallestOfNumbers(int first, int second, int third)
        {
            int minValueOfFirstTwoNumbers = Math.Min(first, second);
            Console.WriteLine(Math.Min(minValueOfFirstTwoNumbers, third));
        }
    }
}
