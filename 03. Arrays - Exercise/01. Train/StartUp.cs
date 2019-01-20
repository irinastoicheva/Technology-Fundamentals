namespace _01._Train
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[] train = new int[number];
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
