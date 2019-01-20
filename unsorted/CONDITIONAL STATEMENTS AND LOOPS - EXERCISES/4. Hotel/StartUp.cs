
namespace _4.Hotel
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());
            int priceForStudioPerNight = 0;
            int priceForDoublePerNight = 0;
            int priceForSuitePerNight = 0;

            if (month == "may")
            {
                priceForStudioPerNight = 50;
                priceForDoublePerNight = 65;
                priceForSuitePerNight = 75;
                if (nightsCount >0 && nightsCount <= 7)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
                else if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * nightsCount * 0.95:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
            }
            else if (month == "june")
            {
                priceForStudioPerNight = 60;
                priceForDoublePerNight = 72;
                priceForSuitePerNight = 82;
                if (nightsCount > 0 && nightsCount <= 14)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
                else if (nightsCount > 14)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount * 0.9:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                priceForStudioPerNight = 68;
                priceForDoublePerNight = 77;
                priceForSuitePerNight = 89;
                if (nightsCount > 0 && nightsCount <= 14)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
                else if (nightsCount > 14)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount * 0.85:F2} lv.");
                }
            }
            else if (month == "september")
            {
                priceForStudioPerNight = 60;
                priceForDoublePerNight = 72;
                priceForSuitePerNight = 82;
                if (nightsCount > 0 && nightsCount <=7)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
                else if (nightsCount > 7 && nightsCount <= 14)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * (nightsCount - 1):F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
                else if (nightsCount > 14)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * (nightsCount - 1) * 0.9:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount * 0.9:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
            }
            if (month == "october")
            {
                priceForStudioPerNight = 50;
                priceForDoublePerNight = 65;
                priceForSuitePerNight = 75;
                if (nightsCount > 0 && nightsCount <= 7)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
                else if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {priceForStudioPerNight * (nightsCount - 1) * 0.95:F2} lv.");
                    Console.WriteLine($"Double: {priceForDoublePerNight * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {priceForSuitePerNight * nightsCount:F2} lv.");
                }
            }
        }
    }
}
