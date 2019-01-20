namespace _08._Company_Users
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
            while (command != "End")
            {
                string[] input = command.Split(" -> ").ToArray();
                string company = input[0];
                string employee = input[1];
                if (!list.ContainsKey(company))
                {
                    list.Add(company, new List<string>());
                }
                if (!list[company].Contains(employee))
                {
                    list[company].Add(employee);
                }
                command = Console.ReadLine();
            }
            list = list.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in list)
            {
                Console.WriteLine(kvp.Key);
                foreach (var employee in kvp.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
