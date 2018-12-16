namespace _09._Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StarUp
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder symbol = new StringBuilder();
            StringBuilder num = new StringBuilder();
            List<string> symbolsAndDijits = new List<string>();
            foreach (var item in input)
            {
                if (item < 48 || item > 57)
                {
                    symbol.Append(item);
                    if (num.Length > 0)
                    {
                        symbolsAndDijits.Add(num.ToString());
                        num.Clear();
                    }
                }
                else
                {
                    num.Append(item);
                    if (symbol.Length > 0)
                    {
                        symbolsAndDijits.Add(symbol.ToString());
                        symbol.Clear();
                    }
                }
            }
            if (symbol.Length > 0)
            {
                symbolsAndDijits.Add(symbol.ToString());
            }
            if (num.Length > 0)
            {
                symbolsAndDijits.Add(num.ToString());
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < symbolsAndDijits.Count; i += 2)
            {
                int number = int.Parse(symbolsAndDijits[i + 1]);
                for (int j = 0; j < number; j++)
                {
                    sb.Append(symbolsAndDijits[i]);
                }
            }
            List<char> countSymbols = new List<char>();
            for (int i = 0; i < sb.Length; i++)
            {
                if (!countSymbols.Contains(sb[i]))
                {
                    countSymbols.Add(sb[i]);
                }
            }
            Console.WriteLine($"Unique symbols used: {countSymbols.Count}");
            Console.WriteLine(sb);
        }
    }
}
