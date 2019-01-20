namespace _10._Refactor_Special_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            for (int i = 1; i <= number; i++)
            {
                bool special = false;

                num = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                if ((sum == 5) || (sum == 7) || (sum == 11))
                {
                    special = true;
                }
                Console.WriteLine($"{num} -> {special}");
                sum = 0;
                i = num;
            }
        }
    }
}
