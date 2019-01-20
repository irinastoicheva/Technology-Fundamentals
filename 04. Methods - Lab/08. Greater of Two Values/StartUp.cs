namespace _08._Greater_of_Two_Values
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string type = Console.ReadLine();
            if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondtString = Console.ReadLine();
                string result = GetMax(firstString, secondtString);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int result = GetMax(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        public static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        public static string GetMax(string firstString, string secondtString)
        {
            if (firstString.CompareTo(secondtString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondtString;
            }
        }
    }
}
