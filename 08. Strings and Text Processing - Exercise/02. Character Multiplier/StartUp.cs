namespace _02._Character_Multiplier
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string firstString = string.Empty;
            string secondString = string.Empty;
            if (input[0].Length >= input[1].Length)
            {
                firstString = input[0];
                secondString = input[1];
            }
            else
            {
                firstString = input[1];
                secondString = input[0];
            }

            int sum = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (i < secondString.Length)
                {
                    sum += firstString[i] * secondString[i];
                }
                else
                {
                    sum += firstString[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
