namespace P02._Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> userCoursePoints = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> courseUserPoints = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();
            while (command != "no more time")
            {
                string[] input = command.Split(" -> ").Where(x => x != "").ToArray();
                string course = input[1];
                string user = input[0];
                int points = int.Parse(input[2]);

                if (!userCoursePoints.ContainsKey(user))
                {
                    userCoursePoints.Add(user, new Dictionary<string, int>());
                    userCoursePoints[user].Add(course, points);
                }
                else if (!userCoursePoints[user].ContainsKey(course))
                {
                    userCoursePoints[user].Add(course, points);
                }
                else if (userCoursePoints[user][course] < points)
                {
                    userCoursePoints[user][course] = points;
                }

                if (!courseUserPoints.ContainsKey(course))
                {
                    courseUserPoints.Add(course, new Dictionary<string, int>());
                }
                if (!courseUserPoints[course].ContainsKey(user))
                {
                    courseUserPoints[course].Add(user, 0);
                }
                if (courseUserPoints[course][user] < points)
                {
                    courseUserPoints[course][user] = points;
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in courseUserPoints)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()} participants");
                int counter = 0;
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {item.Key} <::> {item.Value}");
                }
            }
            Console.WriteLine("Individual standings:");
            int count = 0;
            foreach (var kvp in userCoursePoints.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                count++;
                Console.WriteLine($"{count}. {kvp.Key} -> {kvp.Value.Values.Sum()}");
            }
        }
    }
}
