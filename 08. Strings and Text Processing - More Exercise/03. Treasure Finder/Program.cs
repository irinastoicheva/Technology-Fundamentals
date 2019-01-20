namespace _03._Treasure_Finder
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            List<int> key = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "find")
            {
                string line = input;
                List<int> keyForLine = GetKeyForLine(key, line.Length);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < line.Length; i++)
                {
                    sb.Append((char)(line[i] - keyForLine[i]));
                }

                string cod = sb.ToString();
                sb.Clear();

                string typeOfTreasure = GetString(cod, '&', '&');
                string coordinates = GetString(cod, '<', '>');

                Console.WriteLine($"Found {typeOfTreasure} at {coordinates}");

                input = Console.ReadLine();
            }
        }

        private static string GetString(string cod, char v1, char v2)
        {
            int startIndex = cod.IndexOf(v1) + 1;
            int endIndex = cod.LastIndexOf(v2);

            string word = cod.Substring(startIndex, endIndex - startIndex);
            return word;
        }

        public static List<int> GetKeyForLine(List<int> key, int length)
        {
            int numberOfTheKeyInTheLength = length / key.Count;
            int numberOfCharactersToFillTheLength = length % key.Count;

            List<int> keyForLine = new List<int>();

            for (int i = 0; i < numberOfTheKeyInTheLength; i++)
            {
                for (int j = 0; j < key.Count; j++)
                {
                    keyForLine.Add(key[j]);
                }
            }
            for (int i = 0; i < numberOfCharactersToFillTheLength; i++)
            {
                keyForLine.Add(key[i]);
            }

            return keyForLine;
        }
    }
}
