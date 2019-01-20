namespace _07._Merging_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>();
            if (firstList.Count>= secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    output.Add(firstList[i]);
                    output.Add(secondList[i]);
                }
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    output.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    output.Add(firstList[i]);
                    output.Add(secondList[i]);
                }
                for (int i = firstList.Count; i < secondList.Count; i++)
                {
                    output.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
