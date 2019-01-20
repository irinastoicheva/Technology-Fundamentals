using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> coursesPassword = new Dictionary<string, string>();
            string command = Console.ReadLine();
            while (command != "end of contests")
            {
                string[] input = command.Split(':').ToArray();
                string course = input[0];
                string password = input[1];
                coursesPassword[course] = password;
                command = Console.ReadLine();
            }
            // Dictionary<string, int> userPoints = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> userCoursePoints = new Dictionary<string, Dictionary<string, int>>();
            command = Console.ReadLine();
            while (command != "end of submissions")
            {
                string[] input = command.Split("=>").ToArray();
                string course = input[0];
                string password = input[1];
                string user = input[2];
                int points = int.Parse(input[3]);
                if (coursesPassword.ContainsKey(course) && coursesPassword[course] == password)
                {
                    if (!userCoursePoints.ContainsKey(user))
                    {
                        userCoursePoints.Add(user, new Dictionary<string, int>());
                        userCoursePoints[user].Add(course, points);
                    }
                    else
                    {
                        if (!userCoursePoints[user].ContainsKey(course))
                        {
                            userCoursePoints[user].Add(course, points);
                        }
                        else
                        {
                            if (userCoursePoints[user][course] < points)
                            {
                                userCoursePoints[user][course] = points;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            var userCP = userCoursePoints.OrderByDescending(x => x.Value.Values.Sum()).Take(1);
            int sum = 0;
            string name = string.Empty;
            foreach (var kvp in userCP)
            {
                name = kvp.Key;
                foreach (var item in kvp.Value)
                {
                    sum += item.Value;
                }
            }
            Console.WriteLine($"Best candidate is {name} with total {sum} points.");
            Console.WriteLine("Ranking: ");

            foreach (var kvp in userCoursePoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}

