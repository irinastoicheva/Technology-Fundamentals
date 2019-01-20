namespace _12._Even_Number
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            while (true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    number = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
