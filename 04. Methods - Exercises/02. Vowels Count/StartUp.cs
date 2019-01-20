namespace _02._Vowels_Count
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            PrintCountOfVowels(input);
        }

        private static void PrintCountOfVowels(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' || input[i] == 'i' || input[i] == 'A' || input[i] == 'O' || input[i] == 'U' || input[i] == 'E' || input[i] == 'I')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
