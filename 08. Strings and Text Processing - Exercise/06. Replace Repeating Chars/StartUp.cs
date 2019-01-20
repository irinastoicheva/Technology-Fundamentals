namespace _06._Replace_Repeating_Chars
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> text = new List<char>();
            foreach (var item in input)
            {
                text.Add(item);
            }

            for (int i = 0; i < text.Count - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    text.RemoveAt(i + 1);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", text));
        }
    }
}
