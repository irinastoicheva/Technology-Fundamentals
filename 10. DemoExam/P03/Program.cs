namespace P03
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            int theBestTotalQuality = int.MinValue;
            double averageQuality = int.MinValue;
            int saveCount = 0;
            List<int> totalSave = new List<int>();
            while (command != "Bake It!")
            {
                List<int> taskedToBake = command.Split('#').Select(int.Parse).ToList();
                int totalQuality = taskedToBake.Sum();
                int count = taskedToBake.Count;
               
                if (totalQuality > theBestTotalQuality)
                {
                    theBestTotalQuality = totalQuality;
                    List<int> save = new List<int>(taskedToBake);
                    saveCount = save.Count;
                    averageQuality = save.Sum() / save.Count;
                    totalSave = new List<int>(save);
                }
                else if (totalQuality == theBestTotalQuality)
                {
                    double newAverageQuality = taskedToBake.Sum() / taskedToBake.Count;
                    if (newAverageQuality > averageQuality)
                    {
                        List<int> save = new List<int>(taskedToBake);
                        totalSave = new List<int>(save);
                        saveCount = save.Count;
                        averageQuality = newAverageQuality;
                        theBestTotalQuality = totalQuality;
                    }
                    else if (newAverageQuality == averageQuality)
                    {
                        if (saveCount > count)
                        {
                            List<int> save = new List<int>(taskedToBake);
                            totalSave = new List<int>(save);
                            saveCount = count;
                            averageQuality = newAverageQuality;
                            theBestTotalQuality = totalQuality;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            if (theBestTotalQuality == int.MinValue)
            {
                theBestTotalQuality = 0;
                Console.WriteLine($"Best Batch quality: {theBestTotalQuality}");

            }
            else
            {
                Console.WriteLine($"Best Batch quality: {theBestTotalQuality}");
                Console.WriteLine(string.Join(" ", totalSave));
            }
        }
    }
}
