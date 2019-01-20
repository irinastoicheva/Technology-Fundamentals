namespace _05._List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] command = commands.Split().ToArray();

                switch (command[0])
                {
                    case "Add":
                        input.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        input.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
