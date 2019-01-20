namespace _07._Append_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<int> output = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                int[] numbers = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                output.InsertRange(0, numbers);
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
