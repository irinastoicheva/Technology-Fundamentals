namespace _03._Exact_Sum_of_Real_Numbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
               decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
