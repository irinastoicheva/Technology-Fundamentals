namespace _08._Magic_Sum
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                }
            }
        }
    }
}
