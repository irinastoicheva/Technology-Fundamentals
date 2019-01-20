namespace _04._Printing_Triangle
{
    using System;
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        public static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            for (int i = number; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
