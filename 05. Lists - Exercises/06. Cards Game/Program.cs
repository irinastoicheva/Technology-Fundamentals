namespace _06._Cards_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> firstPleyer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPleyer = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPleyer.Count != 0 && secondPleyer.Count != 0)
            {
                if (firstPleyer[0] > secondPleyer[0])
                {
                    firstPleyer.Add(firstPleyer[0]);
                    firstPleyer.Add(secondPleyer[0]);

                    firstPleyer.RemoveAt(0);
                    secondPleyer.RemoveAt(0);
                }
                else if (firstPleyer[0] == secondPleyer[0])
                {
                    firstPleyer.RemoveAt(0);
                    secondPleyer.RemoveAt(0);
                }
                else
                {
                    secondPleyer.Add(secondPleyer[0]);
                    secondPleyer.Add(firstPleyer[0]);

                    firstPleyer.RemoveAt(0);
                    secondPleyer.RemoveAt(0);
                }
            }
            if (firstPleyer.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPleyer.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstPleyer.Sum()}");
            }
        }
    }
}
