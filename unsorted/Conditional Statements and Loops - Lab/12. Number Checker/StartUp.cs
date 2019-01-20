
namespace _12.Number_Checker
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
