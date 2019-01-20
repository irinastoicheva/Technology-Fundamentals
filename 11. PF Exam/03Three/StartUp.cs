namespace P03Three
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "Retire!")
            {
                string[] line = input.Split(" - ").ToArray();
                string command = line[0];
                string word = line[1];

                switch (command)
                {
                    case "Start":
                        if (!list.Contains(word))
                        {
                            list.Add(word);
                        }
                        break;
                    case "Complete":
                        if (list.Contains(word))
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                list.Remove(word);
                            }
                        }
                        break;
                    case "Side Quest":
                        string[] token = word.Split(':').ToArray();
                        string quest = token[0];
                        string sideQuest = token[1];
                        if (list.Contains(quest))
                        {
                            if (!list.Contains(sideQuest))
                            {
                                int index = list.IndexOf(quest);
                                list.Insert(index + 1, sideQuest);
                            }
                        }
                        break;
                    case "Renew":
                        if (list.Contains(word))
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                list.Remove(word);
                            }
                            list.Add(word);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
