namespace _09._Palindrome_Integers
{
    using System;
    class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                int number = int.Parse(command);
                bool isPalindrome = GetIfTheNumberIsPalindrome(number);
                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                command = Console.ReadLine();
            }
        }

        public static bool GetIfTheNumberIsPalindrome(int number)
        {
            string input = number.ToString();
            bool isPalindrome = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }
    }
}
