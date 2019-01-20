
namespace _13.Game_of_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = numberN; i <= numberM; i++)
            {
                for (int j = numberN; j <= numberM; j++)
                {
                    counter++;
                    if (j + i == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
        }
    }
}
