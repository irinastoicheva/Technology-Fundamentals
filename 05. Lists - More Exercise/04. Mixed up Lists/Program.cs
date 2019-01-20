namespace _04._Mixed_Up_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Startup
    {
        static void Main()
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mix = new List<int>();

            while (first.Count != 0 && second.Count != 0)
            {
                mix.Add(first[0]);
                mix.Add(second[second.Count - 1]);
                first.RemoveAt(0);
                second.RemoveAt(second.Count - 1);
            }
            int num1;
            int num2;
            int start;
            int end;
            if (first.Count == 2)
            {
                num1 = first[0];
                num2 = first[1];
                start = Math.Min(num1, num2);
                end = Math.Max(num1, num2);
            }
            else
            {
                num1 = second[0];
                num2 = second[1];
                start = Math.Min(num1, num2);
                end = Math.Max(num1, num2);
            }

            List<int> output = new List<int>();
            output.AddRange(mix.Where(x => x > start && x < end));
            output.Sort();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}