namespace _04._Longest_Increasing_Subsequence
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] length = new int[input.Length];
            int[] prev = new int[input.Length];

            length[0] = 1;
            prev[0] = -1;
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {

                }
            }
        }
    }
}
