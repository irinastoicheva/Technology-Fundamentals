using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                list.Add(input);
            }

            List<int> counter = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                string pattern = @"[sSTtAaRr]";
                Regex regex = new Regex(pattern);
                var counterLengt = regex.Matches(list[i]);

                counter.Add(counterLengt.Count);
            }

            List<string> replasedList = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                string replased = "";

                for (int k = 0; k < list[i].Length; k++)
                {
                    replased +=(char)(list[i][k] - counter[i]);
                }

                replasedList.Add(replased);
            }

            string planetPattern = @"(?<=@)[A-Za-z]+";
            string popularionPatern = @"(?<=:)[0-9]+";
            string aOrDPattern = @"(?<=!)[A|D]";
            string soldirCount = @"(?<=->)[0-9]+";
            Regex planetRegex = new Regex(planetPattern);
            
            foreach (var item in replasedList)
            {
                 
            }

        }
    }
}
