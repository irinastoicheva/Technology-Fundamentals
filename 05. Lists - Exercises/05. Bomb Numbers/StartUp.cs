namespace _05._Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int [] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bombAndPower = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];
            int savePower = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == bomb)
                {
                    savePower += power;
                    input[i] = 0;
                    int counter = 0;
                    for (int j = i - 1 ; j >= 0; j--)
                    {
                        if (counter == savePower)
                        {
                            break;
                        }
                        input[j] = 0;
                        counter++;
                    }
                    counter = 0;
                    for (int k = i + 1; k < input.Length; k++)
                    {
                        if (counter == savePower)
                        {
                            break;
                        }
                        input[k] = 0;
                        counter++;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            Console.WriteLine(sum);
        }
    }
}
