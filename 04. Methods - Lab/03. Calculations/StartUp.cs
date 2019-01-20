namespace _03._Calculations
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                PrintSumOfNumbers(firstNumber, secondNumber);
            }
            else if (command == "multiply")
            {
                PrintTheWorkOfTheNumbers(firstNumber, secondNumber);
            }
            else if (command == "subtract")
            {
                PrintTheDifferenceOfTheNumbers(firstNumber, secondNumber);
            }
            else if (command == "divide")
            {
                PrintThePrivateOfTheNumbers(firstNumber, secondNumber);
            }
        }

        private static void PrintThePrivateOfTheNumbers(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        private static void PrintTheDifferenceOfTheNumbers(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        private static void PrintTheWorkOfTheNumbers(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        public static void PrintSumOfNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
