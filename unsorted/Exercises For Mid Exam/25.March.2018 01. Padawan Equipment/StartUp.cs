namespace _25.March._2018_01._Padawan_Equipment
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal priceLightsabers = decimal.Parse(Console.ReadLine());
            decimal priceRobes = decimal.Parse(Console.ReadLine());
            decimal priceBelts = decimal.Parse(Console.ReadLine());
            int lightsabers = 0;
            int robes = students;
            int belts = students;

            lightsabers = (int)Math.Ceiling(students * 1.1);
            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    belts--;
                }
            }
            decimal totalPrice = (lightsabers * priceLightsabers) + (robes * priceRobes) + (belts * priceBelts);
            if (totalPrice > money)
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - money:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
        }
    }
}
