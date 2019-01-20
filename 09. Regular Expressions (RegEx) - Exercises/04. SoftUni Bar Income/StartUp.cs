namespace _04._SoftUni_Bar_Income
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            double sum = 0;

            while (command != "end of shift")
            {
                string line = command;

                string pattern = @"^%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?([-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

                MatchCollection matchInput = Regex.Matches(line, pattern);
                string name = "";
                string product = "";
                int count = 0;
                double price = 0;

                foreach (Match item in matchInput)
                {
                    name = item.Groups[1].Value;
                    product = item.Groups[2].Value;
                    count = int.Parse(item.Groups[3].Value);
                    price = double.Parse(item.Groups[4].Value);
                }

                if (name != "")
                {
                    Console.WriteLine($"{name}: {product} - {count * price:f2}");
                    sum += count * price;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
