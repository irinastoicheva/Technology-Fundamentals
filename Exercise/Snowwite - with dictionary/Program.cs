namespace Snowwite___with_dictionary
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            Dictionary<int, Dictionary<string, string>> phisicNameColor = new Dictionary<int, Dictionary<string, string>>();
            string command = Console.ReadLine();

            while (command != "Once upon a time")
            {
                string[] input = command.Split(" <:> ");
                string name = "(" + input[1] + ") " + input[0];
                string color = input[1];
                int phisic = int.Parse(input[2]);

                bool haveDwarf = false;
                foreach (var kvp in phisicNameColor)
                {
                    foreach (var item in kvp.Value)
                    {
                        if (item.Key == name)
                        {
                            haveDwarf = true;
                        }
                    }
                }

                if (haveDwarf)
                {
                    Dictionary<int, Dictionary<string, string>> newDictionary = new Dictionary<int, Dictionary<string, string>>();
                    foreach (var kvp in phisicNameColor)
                    {
                        foreach (var item in kvp.Value)
                        {
                            if (item.Key != name)
                            {
                                if (!newDictionary.ContainsKey(kvp.Key))
                                {
                                    newDictionary.Add(kvp.Key, new Dictionary<string, string>());
                                }
                                newDictionary[kvp.Key].Add(item.Key, item.Value);
                            }
                            else
                            {
                                if (kvp.Key < phisic)
                                {
                                    if (!newDictionary.ContainsKey(phisic))
                                    {
                                        newDictionary.Add(phisic, new Dictionary<string, string>());
                                    }
                                    newDictionary[phisic].Add(item.Key, item.Value);
                                }
                                else
                                {
                                    if (!newDictionary.ContainsKey(kvp.Key))
                                    {
                                        newDictionary.Add(kvp.Key, new Dictionary<string, string>());
                                    }
                                    newDictionary[kvp.Key].Add(item.Key, item.Value);
                                }
                            }
                        }
                        phisicNameColor = newDictionary;
                    }
                }
                else
                {
                    if (!phisicNameColor.ContainsKey(phisic))
                    {
                        phisicNameColor.Add(phisic, new Dictionary<string, string>());
                    }
                    phisicNameColor[phisic].Add(name, color);
                }

                command = Console.ReadLine();
            }

            Dictionary<string, int> colorCount = new Dictionary<string, int>();
            foreach (var kvp in phisicNameColor)
            {
                foreach (var item in kvp.Value)
                {
                    if (!colorCount.ContainsKey(item.Value))
                    {
                        colorCount.Add(item.Value, 0);
                    }
                    colorCount[item.Value] += 1;
                }
            }

            foreach (var kvp in phisicNameColor.OrderByDescending(x => x.Key))
            {
                foreach (var color in colorCount.OrderByDescending(x => x.Value))
                {
                    foreach (var item in kvp.Value)
                    {
                        if (item.Value == color.Key)
                        {
                            Console.WriteLine($"{item.Key} <-> {kvp.Key}");
                        }
                    }
                }
            }
        }
    }
}
