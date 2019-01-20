
namespace _12.Test_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int firstNumber = N; firstNumber >= 1; firstNumber--)
            {
                
                for (int secondNumber = 1; secondNumber <= M; secondNumber++)
                {
                    counter++;
                    sum += 3 * firstNumber * secondNumber;
                    if (sum >= boundary)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {boundary}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
