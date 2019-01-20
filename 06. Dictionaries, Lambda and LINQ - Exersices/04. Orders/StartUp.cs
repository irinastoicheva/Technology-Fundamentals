namespace _04._Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<string> names = new List<string>();
            List<double> prices = new List<double>();
            List<int> quantities = new List<int>();
            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] input = command.Split().ToArray();
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if (!names.Contains(name))
                {
                    names.Add(name);
                    prices.Add(price);
                    quantities.Add(quantity);
                }
                else
                {
                    int index = names.IndexOf(name);
                    prices[index] = price;
                    quantities[index] += quantity;
                }
                command = Console.ReadLine();
            }
            List<double> totalPrice = new List<double>();
            for (int i = 0; i < prices.Count; i++)
            {
                totalPrice.Add(prices[i] * quantities[i]);
            }
            Dictionary<string, double> output = new Dictionary<string, double>();
            for (int i = 0; i < names.Count; i++)
            {
                output.Add(names[i], totalPrice[i]);
            }
            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
