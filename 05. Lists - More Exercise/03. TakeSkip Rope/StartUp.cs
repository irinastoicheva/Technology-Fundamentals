using System;
using System.Collections.Generic;

namespace _03._TakeSkip_Rope

{
    class StartUp
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> text = new List<char>();
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    numbers.Add((int)Char.GetNumericValue(input[i]));
                }
                else
                {
                    text.Add(input[i]);
                }
            }

            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            List<char> output = new List<char>();
            for (int i = 0; i < numbers.Count; i += 2)
            {
                take.Add(numbers[i]);
                skip.Add(numbers[i + 1]);
            }
            while (text.Count > 0 && take.Count > 0 && skip.Count > 0)
            {
                int numberOfTake = take[0];
                int numberOfSkip = skip[0];
                take.RemoveAt(0);
                skip.RemoveAt(0);
                if (numberOfTake > text.Count)
                {
                    numberOfTake = text.Count;
                }
                char[] word = new char[numberOfTake];
                for (int i = 0; i < numberOfTake; i++)
                {
                    word[i] = text[i];
                }
                output.AddRange(word);
                text.RemoveRange(0, numberOfTake);
                if (numberOfSkip > text.Count)
                {
                    numberOfSkip = text.Count;
                }
                text.RemoveRange(0, numberOfSkip);
            }
            Console.WriteLine(string.Join("", output));
        }
    }
}

