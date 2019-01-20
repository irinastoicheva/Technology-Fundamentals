namespace _03._Characters_in_Range
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharInRange(firstChar, secondChar);
            Console.WriteLine();
        }

        private static void PrintCharInRange(char firstChar, char secondChar)
        {
            char minChar = (char)Math.Min(firstChar, secondChar);
            char maxChar = (char)Math.Max(firstChar, secondChar);
            int counter = 0;
            for (char i = minChar; i < maxChar; i++)
            {
                counter++;
                if (counter != 1)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
