namespace _01._Dictionary_DemoExam
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" | ");
            Dictionary<string, List<string>> wordsAndDefinitions = new Dictionary<string, List<string>>();
            for (int i = 0; i < input.Length; i++)
            {
                string[] line = input[i].Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                string word = line[0];
                if (!wordsAndDefinitions.ContainsKey(word))
                {
                    wordsAndDefinitions.Add(word, new List<string>());
                }
                if (!wordsAndDefinitions[word].Contains(line[1]))
                {
                    wordsAndDefinitions[word].Add(line[1]);
                }
            }

            string[] input2 = Console.ReadLine().Split(" | ");
            for (int i = 0; i < input2.Length; i++)
            {
                if (wordsAndDefinitions.ContainsKey(input2[i]))
                {
                    foreach (var kvp in wordsAndDefinitions)
                    {
                        if (kvp.Key == input2[i])
                        {
                            Console.WriteLine(input2[i]);
                            foreach (var item in kvp.Value.OrderByDescending(x => x.Length))
                            {
                                Console.WriteLine($" -{item}");
                            }
                        }
                    }
                }
            }

            string command = Console.ReadLine();
            if (command == "List")
            {
                foreach (var item in wordsAndDefinitions.OrderBy(x => x.Key))
                {
                    Console.Write(item.Key + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
