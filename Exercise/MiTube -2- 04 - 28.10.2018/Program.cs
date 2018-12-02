namespace MiTube__2__04___28._10._2018
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            Dictionary<string, int> nameViews = new Dictionary<string, int>();
            Dictionary<string, int> nameLikes = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "stats time")
            {
                string[] input = command.Split('-').ToArray();

                if (input.Length == 2)
                {
                    string name = input[0];
                    int views = int.Parse(input[1]);

                    if (!nameViews.ContainsKey(name))
                    {
                        nameViews.Add(name, views);
                        nameLikes.Add(name, 0);
                    }
                    else
                    {
                        nameViews[name] += views;
                    }
                }
                else
                {
                    string[] input2 = command.Split(':').ToArray();
                    string name = input2[1];
                    string likes = input2[0];
                    int like = 0;

                    if (likes == "like")
                    {
                        like = 1;
                    }
                    else
                    {
                        like = -1;
                    }

                    if (nameLikes.ContainsKey(name))
                    {
                        nameLikes[name] += like;
                    }
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            if (command == "by likes")
            {
                foreach (var item in nameLikes.OrderByDescending(x => x.Value))
                {
                    Console.Write($"{item.Key} - ");
                    foreach (var kvp in nameViews)
                    {
                        if (kvp.Key == item.Key)
                        {
                            Console.WriteLine($"{kvp.Value} views - {item.Value} likes");
                        }
                    }
                }
            }
            else if (command == "by views")
            {
                foreach (var item in nameViews.OrderByDescending(x => x.Value))
                {
                    Console.Write($"{item.Key} - ");
                    foreach (var kvp in nameLikes)
                    {
                        if (kvp.Key == item.Key)
                        {
                            Console.WriteLine($"{item.Value} views - {kvp.Value} likes");
                        }
                    }
                }
            }
        }
    }
}
