namespace _04._Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).Reverse().Take(3).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
