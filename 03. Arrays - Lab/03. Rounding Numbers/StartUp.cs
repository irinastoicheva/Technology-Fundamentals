namespace _03._Rounding_Numbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in arr)
            {
                Console.WriteLine($"{number} => {Math.Round(number, 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
