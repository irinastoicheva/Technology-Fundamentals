namespace _02._Print_Numbers_in_Reverse_Order
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
