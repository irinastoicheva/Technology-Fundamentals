namespace _05._Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, List<double>>> dragons = new Dictionary<string, Dictionary<string, List<double>>>();
            int numberOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDragons; i++)
            {
                List<string> input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(x => x != "").ToList();
                string type = input[0];
                string name = input[1];
                if (type[0] >= 'A' && type[0] <= 'Z' && name[0] >= 'A' && name[0] <= 'Z')
                {
                    if (input[2] == "null")
                    {
                        input[2] = "45";
                    }
                    double damage = double.Parse(input[2]);
                    if (input[3] == "null")
                    {
                        input[3] = "250";
                    }
                    double health = double.Parse(input[3]);
                    if (input[4] == "null")
                    {
                        input[4] = "10";
                    }
                    double armor = double.Parse(input[4]);

                    if (!dragons.ContainsKey(type))
                    {
                        dragons[type] = new Dictionary<string, List<double>>();
                    }
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new List<double>() { 0, 0, 0 });
                    }

                    dragons[type][name][0] = damage;
                    dragons[type][name][1] = health;
                    dragons[type][name][2] = armor;
                }
            }

            foreach (var type in dragons)
            {
                int count = 0;
                List<double> statistics = new List<double>() {0, 0, 0};
                foreach (var name in type.Value)
                {
                    count++;
                    for (int i = 0; i < 3; i++)
                    {
                        statistics[i] += dragons[type.Key][name.Key][i];
                    }
                }
                statistics = statistics.Select(x => Math.Round((x / count), 2)).ToList();
                Console.WriteLine($"{type.Key}::({statistics[0]:F2}/{statistics[1]:f2}/{statistics[2]:f2})");

                foreach (var name in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{name.Key} -> damage: {dragons[type.Key][name.Key][0]}, health: {dragons[type.Key][name.Key][1]}, armor: {dragons[type.Key][name.Key][2]}");
                }
            }
        }
    }
}
