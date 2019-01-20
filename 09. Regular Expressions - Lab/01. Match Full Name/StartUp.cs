namespace _01._Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ {1}[A-Z][a-z]+\b";

            MatchCollection matchNames = Regex.Matches(input, pattern);
            foreach (Match item in matchNames)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
