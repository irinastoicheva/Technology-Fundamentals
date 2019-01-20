namespace _02._Change_List
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
            while (command != "end")
            {
                string [] com = command.Split().ToArray();
                if (com[0] == "Delete")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input [i] == int.Parse(com[1]))
                        {
                            input.Remove(input[i]);
                            i--;
                        }
                    }
                }
                else if (com[0] == "Insert")
                {
                    input.Insert(int.Parse(com[2]), int.Parse(com[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
