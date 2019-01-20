namespace _11._Multiplication_Table_2._0
{
using System;
    class Program
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 <= 10 && num2 >= 1)
            {
                for (int i = num2; i <= 10; i++)
                {
                    Console.WriteLine($"{num1} X {i} = {num1 * i}");
                }
            }
            else
            {
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
            }
        }
    }
}
