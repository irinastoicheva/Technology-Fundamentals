namespace _01._Remove_Negatives_and_Reverse
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
            list.Reverse();
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
