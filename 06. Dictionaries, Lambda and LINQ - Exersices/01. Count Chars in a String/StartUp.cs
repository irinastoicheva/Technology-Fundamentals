namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<char> input = Console.ReadLine().ToCharArray().Where(x => x != ' ').ToList();
            Dictionary<char, int> list = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!list.ContainsKey(character))
                {
                    list[character] = 0;
                }
                list[character]++;
            }
            foreach (var kpv in list)
            {
                Console.WriteLine($"{kpv.Key} -> {kpv.Value}");
            }
        }
    }
}
