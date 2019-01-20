namespace _09._Sum_of_Odd_Numbers
{
    using System;

    class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number* 2 - 1; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
