namespace _01._Day_of_Week
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            string[] dayOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (input >0 && input <= 7)
            {
                Console.WriteLine(dayOfWeek [input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
