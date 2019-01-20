namespace _05._Word_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList();
            Console.WriteLine(string.Join("\n", input));
        }
    }
}
