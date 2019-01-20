namespace _02._Rainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> side = new List<int>();
            int index = input[input.Length - 1];
            for (int i = 0; i < input.Length - 1; i++)
            {
                side.Add(input[i]);
            }
            int counter = 0;
            while (true)
            {
                side = side.Select(x => x - 1).ToList();
                if (side[index] == 0)
                {
                    break;
                }
                counter++;
                for (int i = 0; i < side.Count; i++)
                {
                    if (side.Contains(0))
                    {
                        side[side.IndexOf(0)] = input[side.IndexOf(0)];
                    }
                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", side));
            Console.WriteLine(counter);
        }
    }
}
