namespace _02._A_Miner_Task
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
       public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, List<int>> list = new Dictionary<string, List<int>>();
            while (command != "stop")
            {
                string resource = command;
                int value = int.Parse(Console.ReadLine());
                if (!list.ContainsKey(resource))
                {
                    list.Add(resource, new List<int>());
                }
                list[resource].Add(value);
                command = Console.ReadLine();
            }
            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Sum()}");
            }
        }
    }
}
