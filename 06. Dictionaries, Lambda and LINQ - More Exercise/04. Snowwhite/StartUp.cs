namespace P04._Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> colorNamePhysic = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();
            while (command != "Once upon a time")
            {
                string[] input = command.Split(" <:> ").ToArray();
                string name = "(" + input[1] + ")" + " " + input[0];
                string color = input[1];
                int physic = int.Parse(input[2]);

                if (!colorNamePhysic.ContainsKey(color))
                {
                    colorNamePhysic.Add(color, new Dictionary<string, int>());
                }
                if (!colorNamePhysic[color].ContainsKey(name))
                {
                    colorNamePhysic[color].Add(name, 0);
                }
                if (colorNamePhysic[color][name] < physic)
                {
                    colorNamePhysic[color][name] = physic;
                }
                command = Console.ReadLine();
            }

            foreach (var kvp in colorNamePhysic.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Values.Count))
            {
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"{item.Key} <-> {item.Value}");
                }
            }
        }
    }
}
