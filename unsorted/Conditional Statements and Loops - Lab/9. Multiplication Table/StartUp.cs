
namespace _9.Multiplication_Table
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 100)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int product = i * number;
                    Console.WriteLine($"{number} X {i} = {product}");
                }
            }
        }
    }
}
