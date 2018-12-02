namespace P01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<string>> wordsDefinition = new Dictionary<string, List<string>>();

            string[] input1 = Console.ReadLine().Split(" | ").ToArray();
            for (int i = 0; i < input1.Length; i++)
            {
                string[] token = input1[i].Split(": ");

                string word = token[0];
                string definitionsOfTheWord = token[1];

                if (!wordsDefinition.ContainsKey(word))
                {
                    wordsDefinition.Add(word, new List<string>());
                }

                wordsDefinition[word].Add(definitionsOfTheWord);
            }

            string[] input2 = Console.ReadLine().Split(" | ");

            for (int i = 0; i < input2.Length; i++)
            {
                if (wordsDefinition.ContainsKey(input2[i]))
                {
                    foreach (var kvp in wordsDefinition)
                    {
                        if (kvp.Key == input2[i])
                        {
                            Console.WriteLine(kvp.Key);
                            foreach (var item in kvp.Value.OrderByDescending(x => x.Length))
                            {
                                Console.WriteLine($" -{item}");
                            }
                        }
                    }
                }
            }

            string input3 = Console.ReadLine();
            if (input3 == "End")
            {
                return;
            }

            if (input3 == "List")
            {
                foreach (var item in wordsDefinition.OrderBy(x => x.Key))
                {
                    Console.Write(item.Key + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
