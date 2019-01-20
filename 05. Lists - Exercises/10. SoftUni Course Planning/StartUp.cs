namespace _10._SoftUni_Course_Planning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] com = command.Split(':').ToArray();
                switch (com[0])
                {
                    case "Add":
                        if (list.Contains(com[1]) == false)
                        {
                            list.Add(com[1]);
                        }
                        break;
                    case "Insert":
                        if (list.Contains(com[1]) == false)
                        {
                            list.Insert(int.Parse(com[2]), com[1]);
                        }
                        break;
                    case "Remove":
                        if (list.Contains(com[1]) == true)
                        {
                            list.Remove(com[1]);
                        }
                        if (list.Contains(com[1] + "-Exercise") == true)
                        {
                            list.Remove(com[1] + "-Exercise");
                        }
                        break;
                    case "Swap":
                        list = Swap(list, com);
                        break;
                    case "Exercise":
                        list = Exercise(list, com);
                        break;
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }
        }

        public static List<string> Exercise(List<string> list, string[] com)
        {
            if (list.Contains(com[1]) == false)
            {
                list.Add(com[1]);
            }
            if (list.Contains(com[1] + "-Exercise") == false)
            {
                int index = list.IndexOf(com[1]);
                list.Insert(index + 1, com[1] + "-Exercise");
            }
            
            return list;
        }

        public static List<string> Swap(List<string> list, string[] com)
        {
            int index1 = list.IndexOf(com[1]);
            int index2 = list.IndexOf(com[2]);
            if (index1 != - 1 && index2 != - 1)
            {
                list[index1] = com[2];
                list[index2] = com[1];

                if (list.Contains(com[1] + "-Exercise") == true)
                {
                    list.Remove(com[1] + "-Exercise");
                    index1 = list.IndexOf(com[1]);
                    list.Insert(index1 + 1, com[1] + "-Exercise");
                }
                if (list.Contains(com[2] + "-Exercise") == true)
                {
                    list.Remove(com[2] + "-Exercise");
                    index2 = list.IndexOf(com[2]);
                    list.Insert(index2 + 1, com[2] + "-Exercise");
                }
            }
            return list;
        }
    }
}
