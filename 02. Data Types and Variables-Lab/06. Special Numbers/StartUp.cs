namespace _06._Special_Numbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int num = 0;
                int sum = 0;
                int counter = i;
                while (counter > 0)
                {
                    num = counter % 10;
                    sum += num;
                    counter /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
