
namespace _8.Sum_of_Odd_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = number* number;
            for (int i = 1; i <= number*2; i+=2)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
