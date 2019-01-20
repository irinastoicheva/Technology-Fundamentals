namespace _01._Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char [] input = Console.ReadLine().ToArray();
            List<char> text = new List<char>();
            List<char> output = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                text.Add(input[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = 0;
                int number = numbers[i];
                while (number > 0)
                {
                    num += number % 10;
                    number /= 10;
                }
                num %= text.Count;
                output.Add(text[num]);
                text.RemoveAt(num);
            }
            Console.WriteLine(string.Join("", output));
        }
    }
}
