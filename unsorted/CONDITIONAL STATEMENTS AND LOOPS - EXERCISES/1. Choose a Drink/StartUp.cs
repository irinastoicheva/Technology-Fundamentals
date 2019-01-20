
namespace _1.Choose_a_Drink
{
    using System;
   public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine().ToLower();
            switch (profession)
            {
                case "athlete":
                    Console.WriteLine("Water");
                    break;
                case "businessman":
                case "businesswoman":
                    Console.WriteLine("Coffe");
                    break;
                case "softUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
