namespace _08._Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] com = command.Split().ToArray();
                string go = com[0];
                switch (go)
                {
                
                    case "merge":
                        int startIndex = int.Parse(com[1]);
                        int endIndex = int.Parse(com[2]);
                        if (startIndex < 0 || startIndex >= input.Count)
                        {
                            startIndex = 0;
                        }
                        if (endIndex >= input.Count || endIndex < 0)
                        {
                            endIndex = input.Count - 1;
                        }
                        input = Merge(input, startIndex, endIndex);
                        break;

                    case "divide":
                        int index = int.Parse(com[1]);
                        if (index < 0 && index >= input.Count)
                        {
                            continue;
                        }
                        int partitions = int.Parse(com[2]);
                        input = Divide(input, index, partitions);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }

        public static List<string> Divide(List<string> input, int index, int partitions)
        {
            string change = input[index];
            input.RemoveAt(index);
            int letters = change.Length / partitions;
            for (int i = 0; i < partitions; i++)
            {
                StringBuilder part = new StringBuilder();
                if (i == partitions - 1)
                {
                    for (int j = i * letters; j < change.Length; j++)
                    {
                        part.Append(change[j]);
                    }
                }
                else
                {
                    for (int j = i * letters; j < (i + 1) * letters; j++)
                    {
                        part.Append(change[j]);
                    }
                }
                input.Insert(index + i, part.ToString());
            }
            return input;
        }

        public static List<string> Merge(List<string> input, int startIndex, int endIndex)
        {
            StringBuilder result = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Append(input[i]);
            }
            input.RemoveRange(startIndex, endIndex - startIndex + 1);
            input.Insert(startIndex, result.ToString());
            return input;
        }
    }
}
