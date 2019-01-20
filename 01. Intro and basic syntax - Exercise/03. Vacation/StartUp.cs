namespace _03._Vacation
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.00;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = count * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = count * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = count * 10.46;
                }
                if (count >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (type == "Business")
            {
                if (count >= 100)
                {
                    count -= 10;
                }
                if (day == "Friday")
                {
                    price = count * 10.9;
                }
                else if (day == "Saturday")
                {
                    price = count * 15.6;
                }
                else if (day == "Sunday")
                {
                    price = count * 16;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = count * 15;
                }
                else if (day == "Saturday")
                {
                    price = count * 20;
                }
                else if (day == "Sunday")
                {
                    price = count * 22.5;
                }
                if (count >= 10 && count <= 20)
                {
                    price *= 0.95;
                }
            }
            Math.Round(price, 2);
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
