namespace _02._Extract_Sentences_by_Keyword
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"\b[^?.!]*\b{word}\b[^?.!]*";
            MatchCollection matchSentences = Regex.Matches(input, pattern);

            foreach (Match item in matchSentences)
            {
                string sentence = item.Value.Trim();
                Console.WriteLine(sentence);
            }
        }
    }
}
