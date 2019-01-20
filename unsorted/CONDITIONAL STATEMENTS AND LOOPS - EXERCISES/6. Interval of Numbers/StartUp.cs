
namespace _6.Interval_of_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            if (numberA < numberB)
            {
                for (int i = numberA; i <= numberB; i++)
                {
                  Console.WriteLine(numberA);
                    numberA++;
                }
            }
            else if (numberA > numberB)
            {
                for (int i = numberB; i <= numberA; i++)
                {
                    Console.WriteLine(numberB);
                    numberB++;
                }
            }
        }
    }
}
