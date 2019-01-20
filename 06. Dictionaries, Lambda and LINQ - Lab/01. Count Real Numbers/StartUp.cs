namespace _01._Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            numbers = numbers.OrderBy(x => x).ToList();

            Dictionary<double, int> result = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }
                result[number]++;
            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
