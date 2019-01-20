namespace _07._Equal_Arrays
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int length = Math.Min(arr1.Length, arr2.Length);
            for (int i = 0; i < length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                sum += arr2[i];
            }
            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {arr1 [arr2.Length]} index");
                return;
            }
            else if (arr1.Length < arr2.Length)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {arr2[arr1.Length]} index");
                return;
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
