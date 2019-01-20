
namespace _8.Calories_Counter
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int totalCaloriesAmount = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    totalCaloriesAmount += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    totalCaloriesAmount += 150;
                }
                else if (ingredients == "salami")
                {
                    totalCaloriesAmount += 600;
                }
                else if (ingredients == "pepper")
                {
                    totalCaloriesAmount += 50;
                }
            }
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
