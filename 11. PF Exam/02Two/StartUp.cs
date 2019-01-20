namespace _02Two
{
    using System;
    using System.Linq;
    class StartUp
    {
        public static void Main()
        {
            int health = 100;
            int money = 0;
            string[] input = Console.ReadLine().Split('|').ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                string[] line = input[i].Split().ToArray();
                string command = line[0];
                int number = int.Parse(line[1]);


                if (command == "potion")
                {
                    int save = 0;
                    if (health + number > 100)
                    {
                        save = number -(health + number - 100);
                        health = 100;
                    }
                    else
                    {
                        save = number;
                        health += number;
                    }
                    Console.WriteLine($"You healed for {save} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    money += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {money}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
