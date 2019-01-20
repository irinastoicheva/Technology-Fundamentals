namespace _09._Padawan_Equipment
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal lightsabers = decimal.Parse(Console.ReadLine());
            decimal robes = decimal.Parse(Console.ReadLine());
            decimal belts = decimal.Parse(Console.ReadLine());

            decimal countLightsabers = Math.Ceiling(1.1M * students);
            decimal priceLightsabers = Math.Round(countLightsabers * lightsabers, 2);

            decimal countBelts = students;
            if (students >= 6)
            {
                int promo = students / 6;
                countBelts -= promo;
            }
            
            decimal priceBelts = Math.Round(countBelts * belts, 2);

            decimal priceRobes = Math.Round(students * robes, 2);

            decimal totalPrice = priceBelts + priceLightsabers + priceRobes;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(totalPrice - money):f2}lv more.");
            }
        }
    }
}
