namespace _06._List_Manipulation_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool isChanged = false;

            while (command != "end")
            {
                string[] com = command.Split().ToArray();
                switch (com[0])
                {
                    case "Add":
                        input.Add(int.Parse(com[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        isChanged = true;
                        input.Remove(int.Parse(com[1]));
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(com[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        input.Insert(int.Parse(com[2]), int.Parse(com[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        PrintContains(input, com);
                        break;
                    case "PrintEven":
                        PrintNumber(input, 0);
                        break;
                    case "PrintOdd":
                        PrintNumber(input, 1);
                        break;
                    case "GetSum":
                        PrintSum(input);
                        break;
                    case "Filter":
                        PrintFilter(input, com);
                        break;
                }
                command = Console.ReadLine();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", input));
            }
        }

        public static void PrintFilter(List<int> input, string[] com)
        {
            List<int> list = new List<int>();
            if (com[1] == "<")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] < int.Parse(com[2]))
                    {
                        list.Add(input[i]);
                    }
                }
            }
            else if (com[1] == ">")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] > int.Parse(com[2]))
                    {
                        list.Add(input[i]);
                    }
                }
            }
            else if (com[1] == "<=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= int.Parse(com[2]))
                    {
                        list.Add(input[i]);
                    }
                }
            }
            else if (com[1] == ">=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] >= int.Parse(com[2]))
                    {
                        list.Add(input[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        public static void PrintSum(List<int> input)
        {
            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }
            Console.WriteLine(sum);
        }

        public static void PrintNumber(List<int> input, int v)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == v)
                {
                    output.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }

        public static void PrintContains(List<int> input, string[] com)
        {
            bool contains = false;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == int.Parse(com[1]))
                {
                    contains = true;
                }
            }
            if (contains)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
