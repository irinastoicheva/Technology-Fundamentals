namespace _04._Back_In_30_Minutes
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            minute += 30;

            if (minute == 60)
            {
                hour += 1;
            }
            else if (minute > 60)
            {
                minute -= 60;
                hour += 1;
            }
            if (hour >= 24)
            {
                hour -= 24;
            }

            Console.WriteLine($"{hour}:{minute:D2}");
        }
    }
}
