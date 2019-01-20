
namespace _6.Theatre_Promotion
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            if (age >=0 && age <=18)
            {
                switch (day)
                {
                    case "weekday":
                        Console.WriteLine("12$");
                        break;
                    case "weekend":
                        Console.WriteLine("15$");
                        break;
                    case "holiday":
                        Console.WriteLine("5$");
                        break;
                }
            }
            else if (age >18 && age <= 64)
            {
                switch (day)
                {
                    case "weekday":
                        Console.WriteLine("18$");
                        break;
                    case "weekend":
                        Console.WriteLine("20$");
                        break;
                    case "holiday":
                        Console.WriteLine("12$");
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (day)
                {
                    case "weekday":
                        Console.WriteLine("12$");
                        break;
                    case "weekend":
                        Console.WriteLine("15$");
                        break;
                    case "holiday":
                        Console.WriteLine("10$");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
