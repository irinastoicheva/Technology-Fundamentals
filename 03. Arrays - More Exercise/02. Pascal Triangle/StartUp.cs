namespace _02._Pascal_Triangle
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                long[] arr = new long[i + 1];
                arr[0] = 1;
                long value = 1;
                for (int j = 0; j < i; j++)
                {
                    value = value * (i - j) / (j + 1);
                    arr[j + 1] = value;
                }
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
