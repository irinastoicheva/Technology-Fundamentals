namespace _08._Letters_Change_Numbers
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            double[] saveNumberOfLines = new double[input.Length];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char[] line = input[i].ToCharArray();
                List<double> numbers = new List<double>();
                List<char> characters = new List<char>();

                bool lastIsLetter = false;

                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] >= '0' && line[j] <= '9' || line[j] == '.') // for digit
                    {
                        if (lastIsLetter)
                        {
                            if (sb.Length > 0)
                            {
                                numbers.Add(double.Parse(sb.ToString()));
                            }
                            sb.Clear();
                        }
                       
                        sb.Append(line[j]);
                        lastIsLetter = false;
                    }
                    else // for letter
                    {
                        characters.Add(line[j]);
                        lastIsLetter = true;
                    }
                }

                if (sb.Length > 0)
                {
                    numbers.Add(int.Parse(sb.ToString()));
                }
                sb.Clear();

                double sum = 0;
                for (int k = 0; k < characters.Count - 1; k ++)
                {
                    if (characters[k] >= 'A' && characters[k] <= 'Z')
                    {
                        sum += 1.0 * numbers[k] / (1.0 * (int)(characters[k] - 64));
                    }
                    else
                    {
                        sum += numbers[k] * (int)(characters[k] - 96);
                    }

                    if (characters[k + 1] >= 'A' && characters[k + 1] <= 'Z')
                    {
                        sum -= (int)(characters[k + 1] - 64);
                    }
                    else
                    {
                        sum += (int)(characters[k + 1] - 96);
                    }

                }
                saveNumberOfLines[i] = sum;
                sum = 0;
            }
            Console.WriteLine($"{saveNumberOfLines.Sum():f2}");
        }
    }
}
