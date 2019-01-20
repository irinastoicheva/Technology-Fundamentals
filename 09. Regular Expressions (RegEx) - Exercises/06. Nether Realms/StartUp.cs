namespace _06._Nether_Realms
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<double>> book = new Dictionary<string, List<double>>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentDemon = input[i];
                string patternHealth = @"[^\+\-\*\./0123456789]";
                MatchCollection matchSymbol = Regex.Matches(currentDemon, patternHealth);
                double health = 0;

                foreach (Match item in matchSymbol)
                {
                    health += (int)item.Value[0];
                }

                string patternNumber = @"[\+\-]*[0-9]+(\.[0-9]+)*";
                MatchCollection matchNumbers = Regex.Matches(currentDemon, patternNumber);
                double damage = 0;

                foreach (Match item in matchNumbers)
                {
                    damage += double.Parse(item.Value);
                }

                string patternMultiplicationAndDivision = @"[*/]";
                MatchCollection match = Regex.Matches(currentDemon, patternMultiplicationAndDivision);

                foreach (Match item in match)
                {
                    if (item.Value.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else if (item.Value.ToString() == "/")
                    {
                        damage /= 2;
                    }
                }

                book.Add(currentDemon, new List<double>());
                book[currentDemon].Add(health);
                book[currentDemon].Add(damage);
            }

            foreach (var kvp in book.OrderBy(x => x.Key))
            {
                Console.Write($"{kvp.Key} ");
                int counter = 0;
                foreach (var item in kvp.Value)
                {
                    if (counter == 0)
                    {
                        Console.Write($"- {item} health, ");
                    }
                    else
                    {
                        Console.WriteLine($"{item:f2} damage ");
                    }
                    counter++;
                }
            }
        }
    }
}
