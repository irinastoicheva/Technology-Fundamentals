namespace _01._Valid_Usernames
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");
            foreach (var item in input)
            {
                string pattern = @"^([\w-]{3,16})$";
                Match match = Regex.Match(item, pattern);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
