namespace ConsoleApp1
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                long [] arr = new long [i + 1];
                arr[0] = 1;
                long value = 1;
                for (int j = 0; j < i; j++)
                {
                    value = value * (i - j) / (j + 1);
                    arr[j + 1] = value;
                }
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
