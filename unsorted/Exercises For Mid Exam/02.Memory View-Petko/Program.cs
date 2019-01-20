namespace _02.Memory_View_Petko
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string tokens = string.Empty;
            while (command != "Visual Studio crash")
            {
                tokens += " " + command;
                command = Console.ReadLine();
            }
            string[] input = tokens.ToString().Split("32656 19759 32763").ToArray();
            List<string> output = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                List<int> 
                    = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                if (events.Count > 0)
                {
                    StringBuilder word = new StringBuilder();
                    for (int j = 3; j < events.Count; j++)
                    {
                        if (events[0] == 0 && events[1] != 0 && events[2] == 0 && events[j] != 0)
                        {
                            word.Append((char)events[j]);
                        }
                    }
                    output.Add(word.ToString());
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}

