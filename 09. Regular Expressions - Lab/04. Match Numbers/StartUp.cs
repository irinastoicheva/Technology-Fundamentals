namespace _04._Match_Numbers
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=^| )(-)?\d+(\.\d+)?(?=$| )";
            MatchCollection matchNumbers = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(" ", matchNumbers));
        }
    }
}
