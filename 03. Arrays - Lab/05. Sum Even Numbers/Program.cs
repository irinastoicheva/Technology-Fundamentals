namespace _05._Sum_Even_Numbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
