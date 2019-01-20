namespace _04._Print_and_sum
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = start; i <= final; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
