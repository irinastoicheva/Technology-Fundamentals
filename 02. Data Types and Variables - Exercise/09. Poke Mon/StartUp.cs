namespace _09._Poke_Mon
{
    using System;
    using System.Numerics;

    class StartUp
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger M = BigInteger.Parse(Console.ReadLine());
            BigInteger Y = BigInteger.Parse(Console.ReadLine());

            BigInteger number = N;
            int counter = 0;

            while (number >= M)
            {
                if (number >= M)
                {
                    number -= M;
                    counter++;
                }
                if (number == N / 2 && Y != 0)
                {
                    number /= Y;
                }
            }
            Console.WriteLine(number);
            Console.WriteLine(counter);
        }
    }
}
