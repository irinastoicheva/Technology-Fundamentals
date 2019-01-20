namespace _05._Star_Enigma
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string patternInput = @"[SsTtAaRr]";
                MatchCollection matchInput = Regex.Matches(input, patternInput);
                int number = matchInput.Count;

                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < input.Length; j++)
                {
                    sb.Append((char)(input[j] - number));
                }

                string message = sb.ToString();
                sb.Clear();
                string patternMessage = @"^[^(@\-!:>)]*@([A-Z][a-z]+)[^(@\-!:>)]*:[^(@\-!:>\d)]*[\d]+[^(@\-!:>)]*![^(@\-!:>AD)]*([AD])[^(@\-!:>AD)]*![^(@\-!:>)]*->[^(@\-!:>\d)]*([\d]+)[^(@\-!:>)]*$";
                MatchCollection matchMessage = Regex.Matches(message, patternMessage);

                string planetName = "";
                string typeAttack = "";

                foreach (Match item in matchMessage)
                {
                    planetName = item.Groups[1].Value;
                    typeAttack = item.Groups[2].Value;
                }

                if (typeAttack == "A")
                {
                    attackedPlanets.Add(planetName);
                }
                else if (typeAttack == "D")
                {
                    destroyedPlanets.Add(planetName);
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var item in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
