namespace _06._Middle_Characters
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            PrintMiddleCharacters(input);
        }

        public static void PrintMiddleCharacters(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[input.Length / 2 - 1]}{input[input.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"{input[input.Length / 2]}");
            }
        }
    }
}
