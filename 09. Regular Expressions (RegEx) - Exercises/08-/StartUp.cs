namespace _08_
{
    using System;
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

            string patternBody = @"<body>([\w\W]+)<\/body>";
            MatchCollection matchBody = Regex.Matches(input, patternBody);
            string body = matchBody[0].Groups[1].Value;

            string patternTags = @"<([\w\W]*?)>";
            MatchCollection matchTags = Regex.Matches(body, patternTags);
            foreach (Match item in matchTags)
            {
                body.Replace(item.Value, string.Empty);
            }



        }
    }
}
