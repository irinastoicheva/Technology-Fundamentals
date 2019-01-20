namespace _07._HTML_Parser
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string patternTitle = @"<title>([\w ]+)<\/title>";
            MatchCollection matchTitle = Regex.Matches(input, patternTitle);

            foreach (Match item in matchTitle)
            {
                Console.WriteLine($"Title: {item.Groups[1].Value}");
            }

            string line = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<' && input[i + 1] == 'b' && input[i + 2] == 'o' && input[i + 3] == 'd' && input[i + 4] == 'y' && input[i + 5] == '>')
                {
                    line = input.Substring(i + 6);
                    break;
                }
            }

            string words = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '<' && line[i + 1] == '/' && line[i + 2] == 'b' && line[i + 3] == 'o' && line[i + 4] == 'd' && line[i + 5] == 'y' && line[i + 6] == '>')
                {
                    words = line.Substring(0, i);
                    break;
                }
            }

            List<char> text = new List<char>();
            foreach (var item in words)
            {
                text.Add(item);
            }
            while (true)
            {
                int startIndex = text.IndexOf('<');
                int endIndex = text.IndexOf('>');

                if (startIndex == -1 || endIndex == -1)
                {
                    break;
                }
                text.RemoveRange(startIndex, endIndex - startIndex + 1);
                text.Insert(startIndex, ' ');
            }

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i] == '\\' && text[i + 1] == 'n')
                {
                    text.RemoveRange(i, 2);
                }
                if (i < text.Count - 1)
                {
                    if (text[i] == ' ' && text[i + 1] == ' ')
                    {
                        text.RemoveAt(i);
                        i--;
                    }
                }
            }

            Console.Write($"Content: ");
            Console.WriteLine(string.Join("", text));
        }
    }
}
