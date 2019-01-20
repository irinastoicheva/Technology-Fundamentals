namespace _10._SoftUni_Exam_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, int> namePoints = new Dictionary<string, int>();
            Dictionary<string, int> languageCount = new Dictionary<string, int>();
            string command = Console.ReadLine();
            while (command != "exam finished")
            {
                string[] input = command.Split("-").ToArray();
                if (input.Length == 3)
                {
                    string name = input[0];
                    string language = input[1];
                    int points = int.Parse(input[2]);

                    if (!namePoints.ContainsKey(name))
                    {
                        namePoints[name] = points;
                    }
                    else
                    {
                        if (points > namePoints[name])
                        {
                            namePoints[name] = points;
                        }
                    }
                    if (!languageCount.ContainsKey(language))
                    {
                        languageCount[language] = 1;
                    }
                    else
                    {
                        languageCount[language]++;
                    }
                }
                else
                {
                    string name = input[0];
                    if (namePoints.ContainsKey(name))
                    {
                        namePoints.Remove(name);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            Console.WriteLine(string.Join(Environment.NewLine,namePoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).Select(x=>$"{x.Key} | {x.Value}")));
            Console.WriteLine("Submissions:");
            Console.WriteLine(string.Join(Environment.NewLine,languageCount.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).Select(x=>$"{x.Key} - {x.Value}")));
        }
    }
}
