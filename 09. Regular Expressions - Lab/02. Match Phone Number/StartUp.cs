namespace _02._Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\+359(-| )2{1}\1\d{3}\1\d{4}\b";
            MatchCollection matchNumber = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", matchNumber));
        }
    }
}
