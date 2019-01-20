namespace _03._Recursive_Fibonacci
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            long[] fibonacci = new long[number];
            fibonacci[0] = 1;

            if (number > 1)
            {
                fibonacci[1] = 1;
                for (int i = 2; i < number; i++)
                {
                    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                }
            }
            Console.WriteLine($"{fibonacci[number - 1]}");
        }
    }
}
