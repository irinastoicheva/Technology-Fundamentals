namespace _02._Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            double sum = 0;
            List<string> names = new List<string>();

            while (command != "Purchase")
            {
                string line = command;

                string patternName = @"(?<=>>)[A-Z]+([a-z]+)?(?=<<)";
                MatchCollection matchName = Regex.Matches(line, patternName);
                string name = string.Empty;
                foreach (Match item in matchName)
                {
                    name = item.Value.ToString();
                }

                string patternPrice = @"(?<=<<)[\d]+(\.)*([\d]+)*(?=!)";
                MatchCollection matchPrice = Regex.Matches(line, patternPrice);
                double price = 0;
                foreach (Match item in matchPrice)
                {
                    price = double.Parse(item.Value);
                }

                string patternQuantity = @"(?<=!)[\d]+(?=\n)*";
                MatchCollection matchQuantity = Regex.Matches(line, patternQuantity);
                int quantity = 0;
                foreach (Match item in matchQuantity)
                {
                    quantity = int.Parse(item.Value);
                }

                if (name != string.Empty && price != 0 && quantity != 0)
                {
                    sum += (price * quantity);
                    names.Add(name);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (names.Count >0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, names));
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
