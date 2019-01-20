namespace _01._Integer_Operations
{
    using System;

    class StartUp
    {
        static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            long fourthNumber = long.Parse(Console.ReadLine());

            long result = (firstNumber + secondNumber) / thirdNumber * fourthNumber;
            Console.WriteLine(result);
        }
    }
}
