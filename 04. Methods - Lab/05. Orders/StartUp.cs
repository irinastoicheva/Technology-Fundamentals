namespace _05._Orders
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            if (product == "coffee")
            {
                price = 1.50;
            }
            else if (product == "water")
            {
                price = 1;
            }
            else if (product == "coke")
            {
                price = 1.4;
            }
            else if (product == "snacks")
            {
                price = 2;
            }
            PrintTotalPrice(quantity, price);
        }

        public static void PrintTotalPrice(int quantity, double price)
        {
            Console.WriteLine($"{quantity * price:F2}");
        }
    }
}
