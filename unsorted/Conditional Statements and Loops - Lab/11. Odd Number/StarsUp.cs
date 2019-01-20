
namespace _11.Odd_Number
{
    using System;
    public class StarsUp
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    Console.WriteLine("The number is: " + Math.Abs(number));
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
        }
    }
}
