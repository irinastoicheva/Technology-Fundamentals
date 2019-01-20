namespace _01._Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
       public static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] com = command.Split().ToArray();
                if (com[0] == "Add")
                {
                  wagons.Add(int.Parse(com[1]));
                }
                else
                {
                    int passengers = int.Parse(com[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
