


namespace _3.Back_in_30_Minutes
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int timeInMinutes = hours*60 + minutes;
            int newTimeInMinutes = timeInMinutes + 30;

            int newHours = newTimeInMinutes / 60;
            int newMinutes = newTimeInMinutes % 60;
            if (newHours <= 23)
            {
                Console.WriteLine($"{newHours}:{newMinutes:D2}");
            }
            else
            {
                Console.WriteLine($"{0}:{newMinutes:D2}");
            }
        }
    }
}
