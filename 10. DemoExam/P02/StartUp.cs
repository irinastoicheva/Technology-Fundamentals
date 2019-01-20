namespace P02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            int energy = 100;
            int coins = 100;
            for (int i = 0; i < input.Count; i++)
            {
                string[] events = input[i].Split('-').ToArray();

                if (events[0] == "rest")
                {
                    int energySave = energy;
                    energy += int.Parse(events[1]);
                    if (energy > 100)
                    {
                        energy = 100;
                    }
                    Console.WriteLine($"You gained {energy - energySave} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (events[0] == "order")
                {
                    if (energy >= 30)
                    {
                        coins += int.Parse(events[1]);
                        Console.WriteLine($"You earned {int.Parse(events[1])} coins.");
                        energy -= 30;
                    }
                    else
                    {
                        Console.WriteLine($"You had to rest!");
                        energy += 50;
                    }
                }
                else
                {
                    int price = int.Parse(events[1]);
                    if (price < coins)
                    {
                        coins -= price;
                        Console.WriteLine($"You bought {events[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {events[0]}.");
                        return;
                    }
                }
            }
            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
