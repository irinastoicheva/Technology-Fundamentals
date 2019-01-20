namespace _06._Strong_number
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numberSave = number;
            int sum = 0;
            while (number > 0)
            {
                int num = number % 10;
                number /= 10;

                int factoriel = 1;
                for (int i = 2; i <= num; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
            }
            if (sum == numberSave)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
