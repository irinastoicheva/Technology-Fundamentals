
namespace _9.Multiplication_Table
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 100)
            {
                if (multiplier<= 10)
                {
                    for (int i = multiplier; i <= 10; i++)
                    {
                        int product = i * number;
                        Console.WriteLine($"{number} X {i} = {product}");
                    }
                }
                else
                {
                    int product = number * multiplier;
                    Console.WriteLine($"{number} X {multiplier} = {product}");
                }
               
            }
        }
    }
}

