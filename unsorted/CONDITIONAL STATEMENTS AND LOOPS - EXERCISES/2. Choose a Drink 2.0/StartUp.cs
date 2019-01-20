
namespace _2.Choose_a_Drink
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "athlete":
                case "Athlete":
                    Console.WriteLine($"The Athlete has to pay {quantity * 0.70:F2}.");
                    break;
                case "businessman":
                case "Businessman":
                    Console.WriteLine($"The Businessman has to pay {quantity * 1.00:F2}.");
                    break;
                case "businesswoman":
                case "Businesswoman":
                    Console.WriteLine($"The Businesswoman has to pay {quantity * 1.00:F2}.");
                    break;
                case "softUni Student":
                case "SoftUni Student":
                    Console.WriteLine($"The SoftUni Student has to pay {quantity * 1.70:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.20:F2}.");
                    break;
            }
        }
    }
}

