namespace _02._Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().ToLower().Split().ToList();
            Dictionary<string, int> list = new Dictionary<string, int>();
            foreach (var word in input)
            {
                if (!list.ContainsKey(word))
                {
                    list[word] = 0;
                }
                list[word]++;
            }
            foreach (var kvp in list)
            {
                if (kvp.Value % 2 == 1)
                {
                    Console.Write(kvp.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
