namespace _08._Condense_Array_to_Number
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int j = 0; j < arr.Length - 1; j++)
            {
                int saveNumber = arr[0];
                for (int i = 0; i < arr.Length-1; i++)
                {
                    arr[i] = arr[i] + arr[i + 1];
                }
            }
            Console.WriteLine(arr[0]);
        }
    }
}
