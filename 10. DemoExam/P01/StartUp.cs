namespace P01
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal priceOffFlour = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfApron = decimal.Parse(Console.ReadLine());

            decimal sumForFlours = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 != 0)
                {
                    sumForFlours += priceOffFlour;
                }
            }
            decimal sumForEggs = students * priceOfEggs * 10;
            int numberOfApron = (int)Math.Ceiling(students * 1.2);
            decimal sumForApron = numberOfApron * priceOfApron;
            decimal totalSum = sumForApron + sumForEggs + sumForFlours;
            if (totalSum <= budget)
            {
                Console.WriteLine($"Items purchased for {Math.Round(totalSum, 2):f2}$.");
            }
            else
            {
                Console.WriteLine($"{Math.Round(Math.Abs(budget - totalSum), 2):f2}$ more needed.");
            }
        }
    }
}
