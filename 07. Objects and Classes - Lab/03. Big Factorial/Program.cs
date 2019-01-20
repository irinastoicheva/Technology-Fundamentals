namespace _03._Big_Factorial
{
    using System;
    using System.Numerics;
    class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 2)
            {
                Console.WriteLine(1);
                return;
            }
            BigInteger factoriel = 1;
            for (int i = 2; i <= number; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
