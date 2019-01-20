namespace _06._Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] input = command.Split(" : ").ToArray();
                string courseName = input[0];
                string studentName = input[1];
                if (!list.ContainsKey(courseName))
                {
                    list.Add(courseName, new List<string>());
                }
                list[courseName].Add(studentName);
                command = Console.ReadLine();
            }
            
            list = list.OrderByDescending(x => x.Value.Count).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", kvp.Value.OrderBy(x => x))}");
            }
        }
    }
}
