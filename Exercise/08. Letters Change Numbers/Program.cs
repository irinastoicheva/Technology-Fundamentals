namespace _08._Letters_Change_Numbers
{
    using System;

    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool firstLetterIsLower = GetIsLower(input[i][0]);
                int firstLetter = GetNumberOfLetter(firstLetterIsLower, input[i][0]);
                bool secondLetterIsLower = GetIsLower(input[i][input[i].Length - 1]);
                int secondLetter = GetNumberOfLetter(secondLetterIsLower, input[i][input[i].Length - 1]);
                double number = GetNumber(input[i]);
                double totalNumber = GetCalculatetNumber(number, firstLetterIsLower, firstLetter, secondLetterIsLower, secondLetter);
                sum += totalNumber;
            }

            Console.WriteLine($"{sum:f2}");
        }

        public static double GetCalculatetNumber(double number, bool firstLetterIsLower, int firstLetter, bool secondLetterIsLower, int secondLetter)
        {
            if (firstLetterIsLower)
            {
                number *= firstLetter;
            }
            else
            {
                number /= firstLetter;
            }

            if (secondLetterIsLower)
            {
                number += secondLetter;
            }
            else
            {
                number -= secondLetter;
            }

            return number;
        }

        private static double GetNumber(string v)
        {
            string num = "";
            for (int j = 1; j < v.Length - 1; j++)
            {
                num += v[j];
            }
            double number = double.Parse(num);
            return number;
        }

        private static int GetNumberOfLetter(bool firstLetterIsLower, char v)
        {
            if (firstLetterIsLower)
            {
                return v - 96;
            }
            else
            {
                return v - 64;
            }
        }

        public static bool GetIsLower(char v)
        {
            if (v >= 65 && v <= 90)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
