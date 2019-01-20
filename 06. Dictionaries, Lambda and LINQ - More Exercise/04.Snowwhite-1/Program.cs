namespace Snowwite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Dwarf
    {
        public Dwarf(string name, string color, int phisic)
        {
            Name = name;
            Color = color;
            Phisic = phisic;
        }
        public string Name { get; set; }

        public string Color { get; set; }

        public int Phisic { get; set; }
    }
    class StartUp
    {
        public static void Main()
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            string command = Console.ReadLine();

            while (command != "Once upon a time")
            {
                string[] input = command.Split(" <:> ");
                string name = "(" + input[1] + ") " + input[0];
                string color = input[1];
                int phisic = int.Parse(input[2]);

                if (dwarfs.Any(x => x.Name == name))
                {
                    Dwarf dwarf;
                    dwarf = dwarfs.Find(x => x.Name == name);
                    if (dwarf.Phisic < phisic)
                    {
                        dwarf.Phisic = phisic;
                    }
                }
                else
                {
                    Dwarf dwarf = new Dwarf(name, color, phisic);
                    dwarfs.Add(dwarf);
                }

                command = Console.ReadLine();
            }

            Dictionary<string, int> colorCount = new Dictionary<string, int>();
            foreach (var dwarf in dwarfs)
            {
                if (!colorCount.ContainsKey(dwarf.Color))
                {
                    colorCount.Add(dwarf.Color, 1);
                }
                colorCount[dwarf.Color] += 1;
            }

            List<Dwarf> sortedDwarfs = new List<Dwarf>();
            foreach (var item in colorCount.OrderByDescending(x => x.Value))
            {
                foreach (var dwarf in dwarfs)
                {
                    if (dwarf.Color == item.Key)
                    {
                        sortedDwarfs.Add(dwarf);
                    }
                }
            }

            foreach (var item in sortedDwarfs.OrderByDescending(x => x.Phisic))
            {
                Console.WriteLine($"{item.Name} <-> {item.Phisic}");
            }
        }
    }
}
