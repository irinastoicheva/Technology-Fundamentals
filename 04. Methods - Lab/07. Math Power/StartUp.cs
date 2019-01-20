namespace _07._Math_Power
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = GetNumberOfPower(number, power);
            Console.WriteLine(result);

        }

        public static double GetNumberOfPower(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
