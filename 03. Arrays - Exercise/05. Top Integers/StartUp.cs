namespace _05._Top_Integers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool isBig = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers [i] <= numbers [j])
                    {
                        isBig = false;
                    }
                }
                if (isBig)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
