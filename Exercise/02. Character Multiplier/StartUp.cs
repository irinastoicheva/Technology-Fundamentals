namespace _02._Character_Multiplier
{
    using System;
    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;
            if (input[0].Length >= input[1].Length)
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    if (i < input[1].Length)
                    {
                        sum += input[0][i] * input[1][i];
                    }
                    else
                    {
                        sum += input[0][i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < input[1].Length; i++)
                {
                    if (i < input[0].Length)
                    {
                        sum += input[1][i] * input[0][i];
                    }
                    else
                    {
                        sum += input[1][i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
