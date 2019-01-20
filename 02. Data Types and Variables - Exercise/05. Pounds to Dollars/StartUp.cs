namespace _05._Pounds_to_Dollars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dolars = pounds * (decimal)1.31;
            Console.WriteLine($"{dolars:F3}");
        }
    }
}
