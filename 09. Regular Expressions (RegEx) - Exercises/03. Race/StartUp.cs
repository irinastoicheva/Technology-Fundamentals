namespace _03._Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class StartUp
    {

        public static void Main()
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();
            string command = Console.ReadLine();
            Dictionary<string, int> list = new Dictionary<string, int>();
            
            while (command != "end of race")
            {
                string line = command;

                string patternName = @"[A-Za-z]+";
                MatchCollection matchName = Regex.Matches(line, patternName);
                StringBuilder sb = new StringBuilder();

                foreach (Match item in matchName)
                {
                    sb.Append(item);
                }
                string name = sb.ToString();
                sb.Clear();

                string patternNumber = @"[\d]";
                MatchCollection matchNumber = Regex.Matches(line, patternNumber);
                int sum = 0;
                foreach (Match item in matchNumber)
                {
                    sum += int.Parse(item.Value);
                }

                if (names.Contains(name))
                {
                    if (!list.ContainsKey(name))
                    {
                        list.Add(name, 0);
                    }
                    list[name] += sum;
                }

                command = Console.ReadLine();
            }

            int counter = 0;
            foreach (var item in list.OrderByDescending(x => x.Value))
            {
                if (counter == 3)
                {
                    return;
                }

                if (counter == 0)
                {
                    Console.WriteLine($"{counter + 1}st place: {item.Key}");
                }
                else if(counter == 1)
                {
                    Console.WriteLine($"{counter + 1}nd place: {item.Key}");
                }
                else
                {
                    Console.WriteLine($"{counter + 1}rd place: {item.Key}");
                }
                counter++;
            }
        }
    }
}
