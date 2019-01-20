namespace _01._Day_of_Week
{
    using System;
    using System.Globalization;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);   
        }
    }
}
