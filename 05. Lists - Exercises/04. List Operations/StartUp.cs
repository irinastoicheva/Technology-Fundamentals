namespace _04._List_Operations
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] com = command.Split().ToArray();
                switch (com[0])
                {
                    case "Add":
                        input.Add(int.Parse(com[1]));
                        break;

                    case "Insert":
                        if (int.Parse(com[2]) < 0 || int.Parse(com[2]) >= input.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            input.Insert(int.Parse(com[2]), int.Parse(com[1]));
                        }
                        break;

                    case "Remove":
                        if (int.Parse(com[1]) < 0 || int.Parse(com[1]) >= input.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            input.RemoveAt(int.Parse(com[1]));
                        }
                        break;

                    case "Shift":
                        if (com[1] == "left")
                        {
                            input = ShiftLeft(input, com);
                        }
                        else if (com[1] == "right")
                        {
                            input = ShiftRight(input, com);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }

        public static List<int> ShiftRight(List<int> input, string[] com)
        {
            int number = int.Parse(com[2]);
            if (number > input.Count)
            {
                number %= input.Count;
            }
            for (int i = 0; i < number; i++)
            {
                input.Insert(0, input[input.Count - 1]);
                input.RemoveAt(input.Count - 1);
            }
            return input;
        }

        public static List<int> ShiftLeft(List<int> input, string[] com)
        {
            int number = int.Parse(com[2]);
            if (number > input.Count)
            {
                number %= input.Count;
            }
            for (int i = 0; i < number; i++)
            {
                input.Add(input[0]);
                input.Remove(input[0]);
            }
            return input;
        }
    }
}
