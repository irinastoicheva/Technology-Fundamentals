namespace _03._Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;
            keyMaterials["motes"] = 0;
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split().Where(x => x != " ").ToArray();
                for (int i = 0; i < input.Length; i+=2)
                {
                    string material = input[i + 1];
                    int quantityMaterial = int.Parse(input[i]);
                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantityMaterial;
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(material))
                        {
                            junkItems[material] = 0;
                        }
                        junkItems[material] += quantityMaterial;
                    }
                    if (keyMaterials["fragments"] >= 250)
                    {
                        keyMaterials["fragments"] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        keyMaterials = keyMaterials.OrderByDescending(kpv => kpv.Value).ThenBy(kpv => kpv.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                        junkItems = junkItems.OrderBy(kpv => kpv.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                        foreach (var kvp in keyMaterials)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        foreach (var kvp in junkItems)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        return;
                    }
                    else if (keyMaterials["shards"] >= 250)
                    {
                        keyMaterials["shards"] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        keyMaterials = keyMaterials.OrderByDescending(kpv => kpv.Value).ThenBy(kpv => kpv.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                        junkItems = junkItems.OrderBy(kpv => kpv.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                        foreach (var kvp in keyMaterials)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        foreach (var kvp in junkItems)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        return;
                    }
                    else if (keyMaterials["motes"] >= 250)
                    {
                        keyMaterials["motes"] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        keyMaterials = keyMaterials.OrderByDescending(kpv => kpv.Value).ThenBy(kpv => kpv.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                        junkItems = junkItems.OrderBy(kpv => kpv.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                        foreach (var kvp in keyMaterials)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        foreach (var kvp in junkItems)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        return;
                    }
                }
            }
        }
    }
}
