namespace _03._Word_Synonyms
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!list.ContainsKey(word))
                {
                    list.Add(word, new List<string>());
                }
                list[word].Add(synonym);
            }
            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
