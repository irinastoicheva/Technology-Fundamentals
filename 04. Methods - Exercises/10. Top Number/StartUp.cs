namespace _10._Top_Number
{
    using System;
    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintMasterNumbers(number);
        }

        public static void PrintMasterNumbers(int number)
        {
            for (int j = 1; j <= number; j++)
            {
                int i = j;
                int sum = 0;
                bool haveOddDigit = false;
                while (i > 0)
                {
                    int num = i % 10;
                    i /= 10;
                    sum += num;
                    if (num % 2 != 0)
                    {
                        haveOddDigit = true;
                    }
                }
                if (haveOddDigit && sum % 8 == 0)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
