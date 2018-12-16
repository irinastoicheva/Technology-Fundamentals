namespace _03._Chore_Wars__28._10._2018
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int totalTime = 0;
            int timeDoingTheDishes = 0;
            int timeCleaningTheHouse = 0;
            int timeDoingTheLaundry = 0;
            while (input != "wife is happy")
            {
                string patternDoingTheDishes = @"(?<=<)[a-z0-9]+(?=>)";
                string patternCleaningTheHouse = @"(?<=\[)[A-Z0-9]+(?=\])";
                string patternDoingTheLaundry = @"(?<=\{)[^\s]+(?=\})";

                Match macth = Regex.Match(input, patternDoingTheDishes);
                if (macth.Success)
                {
                    string word = macth.ToString();
                    for (int i = 0; i < macth.Length; i++)
                    {
                        if (word[i] >= 48 && word[i] <= 57)
                        {
                            timeDoingTheDishes += word[i] - 48;
                        }
                    }
                }

                Match macth2 = Regex.Match(input, patternCleaningTheHouse);
                if (macth2.Success)
                {
                    string word = macth2.ToString();
                    for (int i = 0; i < macth2.Length; i++)
                    {
                        if (word[i] >= 48 && word[i] <= 57)
                        {
                            timeCleaningTheHouse += word[i] - 48;
                        }
                    }
                }

                Match macth3 = Regex.Match(input, patternDoingTheLaundry);
                if (macth3.Success)
                {
                    string word = macth3.ToString();
                    for (int i = 0; i < macth3.Length; i++)
                    {
                        if (word[i] >= 48 && word[i] <= 57)
                        {
                            timeDoingTheLaundry += word[i] - 48;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            totalTime = timeCleaningTheHouse + timeDoingTheDishes + timeDoingTheLaundry;

            Console.WriteLine($"Doing the dishes - {timeDoingTheDishes} min.");
            Console.WriteLine($"Cleaning the house - {timeCleaningTheHouse} min.");
            Console.WriteLine($"Doing the laundry - {timeDoingTheLaundry} min.");
            Console.WriteLine($"Total - {totalTime} min.");
        }
    }
}
