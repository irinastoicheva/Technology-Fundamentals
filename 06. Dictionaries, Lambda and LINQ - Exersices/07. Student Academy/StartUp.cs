namespace _07._Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> list = new Dictionary<string, List<double>>();
            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!list.ContainsKey(name))
                {
                    list.Add(name, new List<double>());
                }
                list[name].Add(grade);
            }
            list = list.Where(x => x.Value.Average() >= 4.5).OrderByDescending(x => x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }
        }
    }
}
