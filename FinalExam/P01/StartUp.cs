namespace P01
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<string>> nameMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> nameTime = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "start of concert")
            {
                string[] line = input.Split(new string[] { "; ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];
                string name = line[1];
                if (command == "Add")
                {
                    if (!nameMembers.ContainsKey(name))
                    {
                        nameMembers.Add(name, new List<string>());
                    }

                    for (int i = 2; i < line.Length; i++)
                    {
                        string member = line[i];
                        if (!nameMembers[name].Contains(member))
                        {
                            nameMembers[name].Add(member);
                        }
                    }
                }
                else if (command == "Play")
                {
                    int time = int.Parse(line[2]);
                    if (!nameTime.ContainsKey(name))
                    {
                        nameTime.Add(name, 0);
                    }
                    nameTime[name] += time;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total time: {nameTime.Values.Sum()}");
            foreach (var item in nameTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            string bandName = Console.ReadLine();
            foreach (var kvp in nameMembers)
            {
                if (kvp.Key == bandName)
                {
                    Console.WriteLine(kvp.Key);
                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"=> {item}");
                    }
                }
            }
        }
    }
}
