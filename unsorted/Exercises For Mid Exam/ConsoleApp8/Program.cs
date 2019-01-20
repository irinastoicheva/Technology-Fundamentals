namespace P03
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int bestQuality = int.MinValue;
            double bestAverageQuality = int.MinValue;
            int bestLength = 0;
            List<int> theBestBred = new List<int>();
            while (input != "Bake It!")
            {
                int[] token = input.Split('#').Select(int.Parse).ToArray();
                int quality = token.Sum();
                double averageQuality = quality / token.Length;
                int length = token.Length;

                if (bestQuality < quality)
                {
                    bestQuality = quality;
                    bestAverageQuality = averageQuality;
                    bestLength = length;
                    theBestBred = new List<int>(token);
                }
                else if (bestQuality == quality)
                {
                    if (bestAverageQuality < averageQuality)
                    {
                        bestAverageQuality = averageQuality;
                        bestLength = length;
                        theBestBred = new List<int>(token);

                    }
                    else if (bestAverageQuality == averageQuality)
                    {
                        if (length < bestLength)
                        {
                            bestLength = length;
                            theBestBred = new List<int>(token);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ", theBestBred));
        }
    }
}
