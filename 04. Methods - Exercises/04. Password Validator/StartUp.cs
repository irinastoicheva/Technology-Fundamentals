namespace _04._Password_Validator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            PrintMessageOfPassword(input);
        }

        public static void PrintMessageOfPassword(string input)
        {
            int numberOfCharacters = GetNumberOfCharacters(input);
            bool isConsistsOfLettersAndNumbersOnly = ChecksIfItConsistsOfLettersAndNumbersOnly(input);
            bool haveAtLeast2Digits = CheckHaveAtLeast2Digits(input);
            if (numberOfCharacters >1 && numberOfCharacters <11 && isConsistsOfLettersAndNumbersOnly && haveAtLeast2Digits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!(numberOfCharacters > 5 && numberOfCharacters < 11))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (isConsistsOfLettersAndNumbersOnly == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (haveAtLeast2Digits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool CheckHaveAtLeast2Digits(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 47 && input[i] < 58)
                {
                    counter++;
                }
            }

            bool haveAtLeast2Digits = false;
            if (counter >= 2)
            {
                haveAtLeast2Digits = true;
            }

            return haveAtLeast2Digits;
        }

        private static bool ChecksIfItConsistsOfLettersAndNumbersOnly(string input)
        {
            bool isConsistsOfLettersAndNumbersOnly = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 48 || input[i] > 57 && input[i] < 65 || input[i] > 90 && input[i] < 97 || input[i] > 123)
                {
                    isConsistsOfLettersAndNumbersOnly = false;
                }
            }

            return isConsistsOfLettersAndNumbersOnly;
        }

        private static int GetNumberOfCharacters(string input)
        {
            int counter = input.Length;
            return counter;
        }
    }
}
