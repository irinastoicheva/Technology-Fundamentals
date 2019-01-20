namespace _03._House_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[2] == "going!")
                {
                    bool isOnTheList = false;
                    if (list.Count > 0)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (list[j] == command[0])
                            {
                                isOnTheList = true;
                            }
                        }
                    }
                    if (isOnTheList)
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        list.Add(command[0]);
                    }
                }
                else if (command[2] == "not")
                {
                    bool isNotOnTheList = true;
                    if (list.Count > 0)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (list[j] == command[0])
                            {
                                isNotOnTheList = false;
                            }
                        }
                    }
                    if (isNotOnTheList)
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                    else
                    {
                        list.Remove(command[0]);
                    }
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
