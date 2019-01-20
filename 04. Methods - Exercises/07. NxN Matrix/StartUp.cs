namespace _07._NxN_Matrix
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrixOfNumbers(number);
        }

        public static void PrintMatrixOfNumbers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
