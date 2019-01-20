namespace _5._Add_and_Subtract
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sumNumbers = Sum(first, second);
            int subtractNumbers = Subtract(sumNumbers, third);
            Console.WriteLine(subtractNumbers);
        }

        public static int Subtract(int sumNumbers, int third)
        {
            return sumNumbers - third;
        }

        public static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
