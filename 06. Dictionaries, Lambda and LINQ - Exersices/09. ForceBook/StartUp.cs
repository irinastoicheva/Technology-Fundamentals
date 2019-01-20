namespace _09._ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command != "Lumpawaroo")
            {
                string[] input = command.Split(" | ").ToArray();
                if (input.Length == 2)
                {
                    string sideName = input[0];
                    string userName = input[1];
                    bool containsThisUser = false;
                    foreach (var kvp in list)
                    {
                        foreach (var user in kvp.Value)
                        {
                            if (kvp.Value.Contains(userName))
                            {
                                containsThisUser = true;
                            }
                        }
                    }
                    if (containsThisUser == false)
                    {
                        if (!list.ContainsKey(sideName))
                        {
                            list.Add(sideName, new List<string>());
                        }
                        if (!list[sideName].Contains(userName))
                        {
                            list[sideName].Add(userName);
                        }
                    }
                }
                else
                {
                    string[] token = command.Split(" -> ").ToArray();
                    string sideName = token[1];
                    string userName = token[0];
                    bool containsThisUser = false;
                    foreach (var kvp in list)
                    {
                        foreach (var user in kvp.Value)
                        {
                            if (kvp.Value.Contains(userName))
                            {
                                containsThisUser = true;
                            }
                        }
                    }
                    if (containsThisUser == false)
                    {
                        if (!list.ContainsKey(sideName))
                        {
                            list.Add(sideName, new List<string>());
                        }
                        list[sideName].Add(userName);
                    }
                    else
                    {
                        string saveKey = string.Empty;
                        foreach (var kvp in list)
                        {
                            foreach (var user in kvp.Value)
                            {
                                if (kvp.Value.Contains(userName))
                                {
                                    saveKey = kvp.Key;
                                    break;
                                }
                            }
                        }
                        list[saveKey].Remove(userName);
                        if (!list.ContainsKey(sideName))
                        {
                            list.Add(sideName, new List<string>());
                        }
                        list[sideName].Add(userName);
                    }
                    Console.WriteLine($"{userName} joins the {sideName} side!");
                }
                command = Console.ReadLine();
            }
            list = list.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in list)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                Console.WriteLine($"! {string.Join("\n! ", kvp.Value.OrderBy(x => x))}");
            }
        }
    }
}
