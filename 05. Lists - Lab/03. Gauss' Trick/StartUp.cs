namespace _03._Gauss__Trick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int final = input.Count / 2;
            for (int i = 0; i < final; i++)
            {
                input[i] = input[i] + input[input.Count - 1];
                input.Remove(input[input.Count - 1]);
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
